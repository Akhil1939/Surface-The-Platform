using Surface.DataAccessLayer.Repositories.Architecture;
using Surface.Entities.DataModels;
using Surface_DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Context;


namespace Surface_DataAccessLayer.Repositories.Architecture
{
    public class UserRepo :BaseRepo<User>, IUserRepo
    {
        private readonly SurfaceContext _context;
        public UserRepo(SurfaceContext context):base(context)
        {
            _context = context;
        }
       
    }
}
