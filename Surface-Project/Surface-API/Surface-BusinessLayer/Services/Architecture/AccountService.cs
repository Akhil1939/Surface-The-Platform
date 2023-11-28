using Google.Apis.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Common.Constants;
using Surface.Common.Utils;
using Surface.Common.Utils.Models;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface.Entities.DataModels;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;
using System.Security.Authentication;
using System.Security.Claims;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class AccountService : BaseService<User>, IAccountService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmailService _emailService;

        public AccountService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IEmailService emailService
            ) : base(uow.UserRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _emailService = emailService;
        }

        public async Task AddAsync(RegisterDTO dto)
        {
            //check if user already exists
            if (await IsEntityExist(x => x.Email == dto.Email))
            {
                throw new Exception("User already exists");
            }

            //hash password
            byte[] salt;
            var HashedPassword = PasswordHelper.HashPassword(dto.Password, out salt);
            User user = new User
            {
                Email = dto.Email,
                Password = HashedPassword,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Salt = Convert.ToBase64String(salt),
                LoginProviderId = 1,
                StatusId = 1,
                AccessFailedCount = 0,
                LockedOutEndDate = null,
                Token = null,
                Avatar = null
            };
            await AddAsync(user);
        }

        public async Task<LoginResponseDTO> GoogleUser(SocialLoginDTO dto)
        {


            //validate token
            var payload = await GoogleJsonWebSignature.ValidateAsync(dto.Token);
            if (payload == null)
            {
                throw new Exception("login token failed");
            }
            //check for user's existence
            User entity = await GetByEmailAsync(payload.Email); //add status validation

            if (entity != null)
            {
                return await GetLoginResponse(entity);
            }
            else
            {
                //map paload to user
                User user = new User
                {
                    Email = payload.Email,
                    FirstName = payload.Name,
                    Password = null,
                    Salt = null,
                    LoginProviderId = 2,
                    StatusId = 1,
                    AccessFailedCount = 0,
                    LockedOutEndDate = null,
                    Avatar = payload.Picture
                };
                await AddAsync(user);

                return await GetLoginResponse(user);
            }
        }

        public async Task<LoginResponseDTO> Login(LoginDTO dto)
        {
            User user = await GetByEmailAsync(dto.Email); //add status validation
            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.AccessFailedCount >= 3)
            {
                if (user.LockedOutEndDate > DateTime.Now)
                {
                    throw new Exception("User is  temporary locked");
                }
                else
                {
                    user.AccessFailedCount = 0;
                    user.LockedOutEndDate = null;
                }
            }

            //check password & varify
            if (PasswordHelper.VerifyPassword(dto.Password, user.Password, Convert.FromBase64String(user.Salt)))
            {

                return await GetLoginResponse(user);
            }
            else
            {
                //reset access failed count
                user.AccessFailedCount = (byte)(user.AccessFailedCount + 1);
                if (user.LockedOutEndDate == null)
                {
                    user.LockedOutEndDate = DateTime.Now.AddMinutes(5);
                }
                await UpdateAsync(user);
                throw new Exception("Invalid credintials");
            }

        }

        public async Task<LoginResponseDTO> GetLoginResponse(User user)
        {
            //get JWT settings
            JwtSetting jwtSettings = new();
            _configuration.GetSection("JwtSetting").Bind(jwtSettings);
            SessionUserModel sessionUserModel = new()
            {
                Id = user.Id,
                Email = user.Email,

            };
            await UpdateAsync(user);
            var token = JwtHelper.GenerateToken(jwtSettings, sessionUserModel);
            LoginResponseDTO response = new()
            {
                LoginToken = token,
                Email = user.Email,
            };
            return response;
        }

        public async Task ForgotPassword(ForgotPasswordDTO dto)
        {
            User? user = await GetByEmailAsync(dto.Email);
            if (user == null)
            {
                return;
            }

            ResetPasswordJwtSetting setting = GetResetPasswordJwtSetting();
            ResetPasswordModel model = SetResetPasswordModel(user.Id, setting.ExpiryMinutes);

            string token = JwtHelper.GenerateToken(setting, model);

            user.Token = token;
            user.ModifiedOn = DateTime.UtcNow;

            string url = GetResetPasswordUrl(token);

            EmailMessage emailMessage = new EmailMessage(new string[] { user.Email }, SystemConstant.EMAIL_HEADING_RESET_PASSWORD, url);
            await _emailService.SendPasswordResetEmailAsync(emailMessage);

            await UpdateAsync(user);

        }

        private async Task<User?> GetByEmailAsync(string email)
        {
            User? user = await GetAsync(u => u.Email == email, null);
            return user;
        }

        private ResetPasswordJwtSetting GetResetPasswordJwtSetting()
        {
            ResetPasswordJwtSetting resetPasswordJwtSetting = new();
            _configuration.GetSection(SystemConstant.RESET_PASSWORD_JWT_SETTING).Bind(resetPasswordJwtSetting);
            return resetPasswordJwtSetting;
        }

        private ResetPasswordModel SetResetPasswordModel(long id, int expiryMinutes)
        {
            DateTime validTill = DateTime.UtcNow.AddMinutes(expiryMinutes);

            ResetPasswordModel model = new()
            {
                Id = id,
                VaildTill = validTill,
            };
            return model;
        }

        private string GetResetPasswordUrl(string token)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var baseUrl = $"{request.Scheme}://{request.Host.Value}";
            string url = $"{baseUrl}{SystemConstant.ENDPOINT_RESET_PASSWORD}?token={token}";
            return url;
        }

        public async Task ResetPasswordAsync(string token, ResetPasswordDTO dto)
        {
            ResetPasswordJwtSetting setting = GetResetPasswordJwtSetting();

            ResetPasswordModel model = GetResetPasswordModel(setting, token);

            User user = await _uow.UserRepo.GetByIdAsync(model.Id);

            //check if there is token with associated user in db
            if (user.Token != token) throw new AuthenticationException(ExceptionMessage.UNAUTHORIZED);

            user.ModifiedOn = DateTime.UtcNow;
            user.Token = null;

            if (JwtHelper.IsTokenExpired(token))
            {
                await UpdateAsync(user);
                throw new AuthenticationException(ExceptionMessage.RESET_PASSWORD_TOKEN_EXPIRED);
            }

            byte[] salt;
            user.Password = PasswordHelper.HashPassword(dto.Password, out salt);
            user.Salt = Convert.ToHexString(salt);
            await UpdateAsync(user);
        }

        private ResetPasswordModel GetResetPasswordModel(ResetPasswordJwtSetting setting, string token)
        {
            ClaimsPrincipal? claimsPrincipal = JwtHelper.ValidateJwtToken(setting, token);

            if (claimsPrincipal == null)
            {
                throw new UnauthorizedAccessException();
            }

            Claim? idClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);
            Claim? validTillClaim = claimsPrincipal.FindFirst("ValidTill");

            if (idClaim == null || validTillClaim == null)
            {
                throw new InvalidOperationException(ExceptionMessage.INVALID_CLAIMS);
            }

            long id = long.Parse(idClaim.Value);
            DateTime validTill = DateTime.Parse(validTillClaim.Value);

            ResetPasswordModel model = new ResetPasswordModel
            {
                Id = id,
                VaildTill = validTill
            };

            return model;
        }
    }
}

