

using Surface_Entities.DTOs.Team_Member;

namespace Surface_Entities.DTOs.Team
{
    public class TeamDetailedDTO
    {
        public TeamDTO Team { get; set; } = new TeamDTO();
        public List<TeamMemberDTO> TeamMember { get; set; } = new List<TeamMemberDTO> { new TeamMemberDTO() };

    }
}
