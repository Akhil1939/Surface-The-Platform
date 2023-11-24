

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
            _context=context;
        }


        public async Task<Project> GetProjectById(long Id)
        {
            return await _context.Projects.Where(p => p.Id == Id).FirstOrDefaultAsync() ?? throw new Exception("Project not found");
        }
    }
}
