using Surface.DataAccessLayer.Repositories.Architecture;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;
using Surface_Entities.Entities;


namespace Surface_DataAccessLayer.Repositories.Architecture
{
    internal class TeamMemberRepo : BaseRepo<TeamMember>, ITeamMemberRepo
    {
        public SurfaceContext _context;
        public TeamMemberRepo(SurfaceContext context) : base(context)
        {
            _context = context;
        }
    }
}
