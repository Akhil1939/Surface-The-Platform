using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Entities.DataModels;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IAccountService : IBaseService<User>
    {
        Task AddAsync(RegisterDTO dTO);

        Task<LoginResponseDTO> Login(LoginDTO dto);
        Task ForgotPassword(ForgotPasswordDTO dto);
        Task ResetPasswordAsync(string token, ResetPasswordDTO dto);
        Task<LoginResponseDTO> GoogleUser(SocialLoginDTO dto);

    }
}
