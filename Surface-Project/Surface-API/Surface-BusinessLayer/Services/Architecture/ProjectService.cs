using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;


namespace Surface_BusinessLayer.Services.Architecture
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ProjectService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(uow.ProjectRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task Add(UpsertProjectDTO dto)
        {
            Project createProject = new()
            {
                Name = dto.Name,
                Description = dto.Description,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                RepoLink = dto.RepoLink,
                Budget = dto.Budget,
                StatusId = 1,
                CreatedBy = 1,
                ModifiedBy = 1,
            };
            await AddAsync(createProject);
        }
        public async Task<Project> GetById(long id)
        {
            return await _uow.ProjectRepo.GetByIdAsyncTracible(id);
        }
        public async Task DeleteProject(long id)
        {
            await _uow.ProjectRepo.Delete(id);

        }

        public Task UpdateProjectStatus()
        {
            throw new NotImplementedException();
        }




    }
}
