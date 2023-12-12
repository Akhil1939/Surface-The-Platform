

using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IProjectService:IBaseService<Project>
    {
        Task<long> Add(AddProjectDTO dto);
        Task DeleteProject(long id);
         Task<Project> GetById(long id);
        Task UpdateProjectStatus(long projectId, byte statusId)

    }
}
