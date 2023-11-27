using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surface_DataAccessLayer.Repositories.Infrastructure
{
    public interface ITeamRepo:IBaseRepo<Team>
    {
        //get tracible entity
        Task<Team> GetByIdAsyncTracible(long id);
        Task Delete(long id);
    }
}
