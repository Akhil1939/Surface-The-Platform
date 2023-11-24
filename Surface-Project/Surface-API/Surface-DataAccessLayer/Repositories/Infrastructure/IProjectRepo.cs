using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Entities;


namespace Surface_DataAccessLayer.Repositories.Infrastructure
{
    public interface IProjectRepo :IBaseRepo<Project>
    {
        Task<Project> GetProjectById(long Id);
    }
}
