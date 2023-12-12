

namespace Surface_Entities.DTOs.Team_Member
{
    public class TeamInviteRequestDTO
    {
        public string Email { get; set; } = null!;
        public byte RoleId { get; set; }
    }
}
