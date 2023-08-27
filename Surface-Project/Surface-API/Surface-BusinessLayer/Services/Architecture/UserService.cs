using Google.Apis.Auth;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.Common.Utils;
using Surface.Common.Utils.Models;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface.Entities.DataModels;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        public UserService(IUnitOfWork uow, IConfiguration configuration) : base(uow.UserRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
        }

        public async Task AddAsync(RegisterDTO dTO)
        {
            switch (dTO.loginProviderId)
            {
                case 1:
                    await CustomRegister(dTO);
                    break;
                case 2:
                    await AddGoogleUser(dTO);
                    break;
                //case 3:
                //    await AddFacebookUser(dTO);
                //    break;
                default:
                    break;

            }

        }

        private async Task CustomRegister(RegisterDTO dto)
        {
            //validate dto
            if (dto.Email == null || dto.Password == null)
            {
                throw new Exception("Email or Password is null");
            }

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
                Salt = Convert.ToBase64String(salt),
                LoginProviderId = dto.loginProviderId,
                StatusId = 1,
                AccessFailedCount = 0,
                LockedOutEndDate = null,
                Avatar = null
            };
            await AddAsync(user);
        }

        private async Task AddGoogleUser(RegisterDTO dto)
        {
            //check validation
            if (dto.LoginToken == null)
            {
                throw new Exception("login token failed");
            }

            //validate token
            var payload = await GoogleJsonWebSignature.ValidateAsync(dto.LoginToken);
            if (payload == null)
            {
                throw new Exception("login token failed");
            }
            //check for user's existence
            if (await IsEntityExist(x => x.Email == payload.Email))
            {
                //go for login
            }
            else
            {
                //map paload to user
                User user = new User
                {
                    Email = payload.Email,
                    Password = null,
                    Salt = null,
                    LoginProviderId = dto.loginProviderId,
                    StatusId = 1,
                    AccessFailedCount = 0,
                    LockedOutEndDate = null,
                    Avatar = payload.Picture
                };
                await AddAsync(user);
            }
        }

        public async Task<LoginResponseDTO> Login(LoginDTO dto)
        {
            User user = await GetAsync(x => x.Email == dto.Email) ?? throw new Exception("User not found"); //add status validation

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
                //get JWT settings
                JwtSetting jwtSettings = new();
                _configuration.GetSection("JwtSetting").Bind(jwtSettings);
                SessionUserModel sessionUserModel = new()
                {
                    Id = user.Id,
                    Email = user.Email,

                };
                var token = JwtHelper.GenerateToken(jwtSettings, sessionUserModel);
                LoginResponseDTO response = new()
                {
                    LoginToken = token,
                    Email = user.Email,
                };
                await UpdateAsync(user);
                return response;
            }
            else
            {
                //reset access failed count
                user.AccessFailedCount = (byte)(user.AccessFailedCount + 1);
                if(user.LockedOutEndDate == null)
                {
                    user.LockedOutEndDate = DateTime.Now.AddMinutes(5);
                }
                await UpdateAsync(user);
                throw new Exception("Invalid credintials");
            }

        }
    }
}

