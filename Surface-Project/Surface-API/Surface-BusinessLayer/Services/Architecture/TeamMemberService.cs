
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.Entities;

namespace Surface_BusinessLayer.Services.Architecture
{
    public class TeamMemberService : BaseService<TeamMember>, ITeamMemberService
    {
        private readonly IUnitOfWork _uow;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TeamMemberService(IUnitOfWork uow, IConfiguration configuration, IHttpContextAccessor httpContextAccessor) : base(uow.TeamMemberRepo, uow)
        {
            _uow = uow;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }
    }
}
