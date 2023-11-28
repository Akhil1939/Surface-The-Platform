using Microsoft.EntityFrameworkCore;
using Surface.Common.Enums;
using Surface.DataAccessLayer.Repositories.Architecture;
using Surface.Entities.DataModels;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;
using Surface_Entities.DTOs.Team_Member;
using Surface_Entities.Entities;


namespace Surface_DataAccessLayer.Repositories.Architecture
{
    public class TeamRepo : BaseRepo<Team>, ITeamRepo
    {
        private readonly SurfaceContext _context;
        public TeamRepo(SurfaceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Team> GetByIdAsyncTracible(long id)
        {
            return await _context.Teams.Where(x => x.Id == id).FirstOrDefaultAsync() ?? throw new Exception("Team not Found");
        }

        public async Task Delete(long id)
        {
            _context.Teams.Remove(await GetByIdAsyncTracible(id));
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeamMember>> InviteTeamMember(List<TeamInviteRequestDTO> Invites, long TeamId)
        {
            // get UserId and Email of users
            var userIdEmails = _context.Users
               .Where(user => Invites.Select(invite => invite.Email).Contains(user.Email))
               .Select(user => new { UserId = user.Id, Email = user.Email })
               .ToList();

            // Create TeamMember entities for the invited users
            var teamMembersToInvite = userIdEmails
                .Select(x => new TeamMember
                {
                    UserId = x.UserId,
                    TeamId = TeamId,
                    StatusId = (byte)StatusEnum.TeamMember.Pending,
                    UserRoleId = Invites.First(invite => invite.Email == x.Email).RoleId,
                    VerificationToken = GenerateVerificationToken(),
                    Email = x.Email,
                })
                .Where(teamMember => !_context.TeamMembers.Any(existingTeamMember =>
                    existingTeamMember.UserId == teamMember.UserId &&
                    existingTeamMember.TeamId == teamMember.TeamId))
                .ToList();

            // Add the TeamMember entities to the database
            
            return teamMembersToInvite;
        }

        // Helper method to generate a unique verification token
        private string GenerateVerificationToken()
        {
            // Implement your logic to generate a unique token (e.g., using Guid.NewGuid())
            return Guid.NewGuid().ToString();
        }

        public async Task<List<InvitedMemberDTO>> GetInvitedMember(long teamId)
        {
            return await _context.TeamMembers.Where(member => member.TeamId == teamId).Include(x => x.Users).Select(InvitedMember => new InvitedMemberDTO()
            {
                UserId = InvitedMember.UserId,
                RoleId = InvitedMember.UserRoleId,
                UserName = InvitedMember.Users.FirstName + " " + InvitedMember.Users.LastName,
                Status = InvitedMember.Status.Name,
                Email = InvitedMember.Users.Email,

            }).ToListAsync();

        }
    }
}
