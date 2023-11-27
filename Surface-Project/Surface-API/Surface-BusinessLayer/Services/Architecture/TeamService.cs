

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Team;
using Surface_Entities.Entities;
using System.Linq.Expressions;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TeamService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(uow.TeamRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }
        public async Task Upsert(TeamDTO dto)
        {
            if (dto.Id > 0)
            {
                Team teamToUpdate = await _uow.TeamRepo.GetByIdAsyncTracible(dto.Id);
                teamToUpdate.Name = dto.Name;
                if (dto.ProjectId != teamToUpdate.ProjectId)
                {
                    Expression<Func<Project, bool>> predicate = x => x.Id == dto.ProjectId;
                    if (await _uow.ProjectRepo.IsEntityExist(predicate))
                    {

                        teamToUpdate.ProjectId = dto.ProjectId;
                    }
                    else throw new Exception("team repo - project not found for given Id");
                }
                await _uow.SaveAsync();

            }
            else
            {
                Expression<Func<Project, bool>> predicate = x => x.Id == dto.ProjectId;
                if (await _uow.ProjectRepo.IsEntityExist(predicate))
                {
                    Team teamToAdd = new()
                    {
                        Name = dto.Name,
                        ProjectId = dto.ProjectId
                    };
                    await AddAsync(teamToAdd);
                }
                else throw new Exception("team repo - project not found for given Id");

            }
        }

        public async Task Delete(long id)
        {
            await _uow.TeamRepo.Delete(id);
        }

        public async Task<TeamDTO> GetTeam(long id)
        {
            Team team = await _uow.TeamRepo.GetByIdAsyncTracible(id);
            return new TeamDTO()
            {
                Id = team.Id,
                Name = team.Name,
                ProjectId = team.ProjectId
            };

        }
    }
}
