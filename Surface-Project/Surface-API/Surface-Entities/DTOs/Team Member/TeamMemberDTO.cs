
namespace Surface_Entities.DTOs.Team_Member
{
    public class TeamMemberDTO
    {
        public long Id { get; set; }
        public long TeamId { get; set; }
        public long UserId { get; set; }
        public byte UserRoleId { get; set; }
        public byte StatusId { get; set; }
    }
}
