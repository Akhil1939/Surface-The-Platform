using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface.Entities.DataModels;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Project;
using Surface_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class ProjectService : BaseService<Project> ,IProjectService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ProjectService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) :base(uow.ProjectRepo, uow) 
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task UpsertProject(UpsertProjectDTO dto)
        {
           //check for update or insert

           if(dto.Id == 0)//Add new project
            {
                Project createProject = new Project()
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
            else
            {
                Project projectToUpdate = await GetById(dto.Id);

                if (projectToUpdate.Name != dto.Name)
                    projectToUpdate.Name = dto.Name;

                if (projectToUpdate.Description != dto.Description)
                    projectToUpdate.Description = dto.Description;

                if (projectToUpdate.StartDate != dto.StartDate)
                    projectToUpdate.StartDate = dto.StartDate;

                if (projectToUpdate.EndDate != dto.EndDate)
                    projectToUpdate.EndDate = dto.EndDate;

                // Actual start date and end date will be added by another call/function

                if (projectToUpdate.RepoLink != dto.RepoLink)
                    projectToUpdate.RepoLink = dto.RepoLink;

                if (projectToUpdate.Budget != dto.Budget)
                    projectToUpdate.Budget = dto.Budget;


                await _uow.SaveAsync();
            }
        }
        public async Task<Project> GetById(long id)
        {
            return await _uow.ProjectRepo.GetProjectById(id);

        }
        public Task DeleteProject()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProjectStatus()
        {
            throw new NotImplementedException();
        }

     

        
    }
}
