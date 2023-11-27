using Microsoft.EntityFrameworkCore;
using Surface.DataAccessLayer.Repositories.Architecture;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;
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
            return await _context.Teams.Where(x => x.Id == id).FirstOrDefaultAsync() ??throw new Exception ("Team not Found");
        }

        public async Task Delete(long id)
        {
         _context.Teams.Remove(await GetByIdAsyncTracible(id));
            await _context.SaveChangesAsync();
        }
    }
}
