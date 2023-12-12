
using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Entities.DataModels;
using Surface_Entities.DTOs;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IUserService:IBaseService<User>
    {
        Task<List<EmailDTO>> GetEmailList(string query);
    }
}
