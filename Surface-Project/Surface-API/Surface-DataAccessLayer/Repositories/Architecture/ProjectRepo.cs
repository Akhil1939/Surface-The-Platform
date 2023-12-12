

using Microsoft.EntityFrameworkCore;
using Surface.DataAccessLayer.Repositories.Architecture;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;
using Surface_Entities.Entities;

namespace Surface_DataAccessLayer.Repositories.Architecture
{
    public class ProjectRepo : BaseRepo<Project>, IProjectRepo
    {
        private readonly SurfaceContext _context;
        public ProjectRepo(SurfaceContext context) : base(context)
        {
            _context = context;
        }

        public async Task Delete(long id)
        {
            _context.Projects.Remove(await GetByIdAsyncTracible(id));
            await _context.SaveChangesAsync();
        }


        public async Task<Project> GetByIdAsyncTracible(long Id)
        {
            return await _context.Projects.Where(p => p.Id == Id).FirstOrDefaultAsync() ?? throw new Exception("Project not found");
        }

        public async Task UpdateStatus(long Id, byte StatusId)

        {

            if (await _context.Projects.Where(p => p.Id == Id).ExecuteUpdateAsync(setter => setter.SetProperty(entity => entity.StatusId, StatusId)) > 0)
            {
                return;
            }
            else
            {
                throw new Exception("Error while updating project status");
            }

        }
    }
}
