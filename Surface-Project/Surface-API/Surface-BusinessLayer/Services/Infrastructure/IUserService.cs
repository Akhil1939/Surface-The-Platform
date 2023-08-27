using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Entities.DataModels;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IUserService : IBaseService<User>
    {
        Task AddAsync(RegisterDTO dTO);

        Task<LoginResponseDTO> Login(LoginDTO dto);

    }
}
