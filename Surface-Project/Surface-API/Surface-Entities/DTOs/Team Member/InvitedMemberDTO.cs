

namespace Surface_Entities.DTOs.Team_Member
{
    public class InvitedMemberDTO
    {
        public  long UserId { get; set; }
        public long RoleId { get; set; }
        public string Status { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? UserName { get; set; }
    }
}
