using StudentJobs.Entities.DTOs;
using System.Linq.Expressions;
namespace Surface.BusinessAccessLayer.Services.Infrastructure
{
    public interface IBaseService<T> where T : class
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[]? includes = null, string[]? thenIncludes = null, Expression<Func<T, T>>? selects = null);
        Task<PageListResponseDTO<T>> GetAllAsync(PageListRequestEntity<T> pageListRequest);
        Task<bool> IsEntityExist(Expression<Func<T, bool>> predicate);

    }
}
