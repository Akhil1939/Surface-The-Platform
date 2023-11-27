using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_DataAccessLayer.Repositories.Architecture;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;

namespace Surface.DataAccessLayer.Repositories.Architecture
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SurfaceContext _context;
        private IUserRepo _userRepo;
        private IProjectRepo _projectRepo;
        private ITeamRepo _teamRepo;

        public UnitOfWork(SurfaceContext context)
        {
            _context = context;
        }
        public void Save()
             => _context.SaveChanges();

        public async Task SaveAsync()
            => await _context.SaveChangesAsync();

        public void Rollback()
            => _context.Dispose();

        public async Task RollbackAsync()
            => await _context.DisposeAsync();

        public IBaseRepo<T> GetRepository<T>() where T : class
        {
            return new BaseRepo<T>(_context);
        }

        public IUserRepo UserRepo
        {
            get
            {
                return _userRepo ??= new UserRepo(_context);
            }
        }
        public IProjectRepo ProjectRepo
        {
            get
            {
                return _projectRepo ??= new ProjectRepo(_context);
            }
        }
        public ITeamRepo TeamRepo
        {
            get
            {
                return _teamRepo ??= new TeamRepo(_context);
            }
        }
    }
}
