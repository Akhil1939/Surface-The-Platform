

using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MimeKit;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Common.Utils.Models;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface.Entities.DataModels;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.DTOs.Team;
using Surface_Entities.DTOs.Team_Member;
using Surface_Entities.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class TeamService : BaseService<Team>, ITeamService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEmailService _emailService;
        public TeamService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor, IEmailService emailService) : base(uow.TeamRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _emailService = emailService;

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
       public async Task InviteTeamMember(List<TeamInviteRequestDTO> Invites, long TeamId)
        {
            IEnumerable<TeamMember> memberToInvite= await _uow.TeamRepo.InviteTeamMember(Invites, TeamId);
            if (memberToInvite.Any())
            {
                await _uow.TeamMemberRepo.AddRangeAsync(memberToInvite);
                await _uow.SaveAsync();

                // Send invitations
                foreach (var teamMember in memberToInvite)
                {
                    var invitationLink = GenerateInvitationLink(teamMember.VerificationToken);

                    EmailMessage emailMessage = new EmailMessage(new string[] { teamMember.Email }, "TeamInvite", invitationLink);
                    await _emailService.SendTeamInviteEmailAsync(emailMessage);

                }
            }
        }

        private string GenerateInvitationLink(string verificationToken)
        {
            // Replace "yourapp.com" with your actual domain
            return $"https://yourapp.com/accept-invite?token={verificationToken}";
        }

        public async Task<List<InvitedMemberDTO>> GetInvitedMemberList(long teamId)
        {
            return await _uow.TeamRepo.GetInvitedMember(teamId);

        }

       
    }
}
