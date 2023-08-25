using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Entities.DataModels;


namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IUserService : IBaseService<User>
    {
        User GetById(long id);
        User GetByEmail(string email);
        User GetByUserName(string userName);

    }
}
