

using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface IProjectService:IBaseService<Project>
    {
        Task UpsertProject(UpsertProjectDTO dto);
        Task UpdateProjectStatus();
        Task DeleteProject();
         Task<Project> GetById(long id);

    }
}
