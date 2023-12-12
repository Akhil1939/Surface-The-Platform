using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.DTOs.Team_Member;
using Surface_Entities.Entities;


namespace Surface_DataAccessLayer.Repositories.Infrastructure
{
    public interface ITeamRepo:IBaseRepo<Team>
    {
        //get tracible entity
        Task<Team> GetByIdAsyncTracible(long id);
        Task Delete(long id);
        Task<IEnumerable<TeamMember>> InviteTeamMember(List<TeamInviteRequestDTO> Invites, long TeamId);
        Task<List<InvitedMemberDTO>> GetInvitedMember(long teamId);
    }
}
