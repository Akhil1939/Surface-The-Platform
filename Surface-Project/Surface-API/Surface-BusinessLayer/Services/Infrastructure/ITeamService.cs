

using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Team;
using Surface_Entities.Entities;

namespace Surface_BusinessLayer.Services.Infrastructure
{
    public interface ITeamService:IBaseService<Team>
    {
        Task Upsert(TeamDTO dto);
        Task Delete(long id);
        Task<TeamDTO> GetTeam(long id);
    }
}
