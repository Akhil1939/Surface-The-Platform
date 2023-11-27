using Microsoft.EntityFrameworkCore;
using StudentJobs.Entities.DTOs;
using Surface_Entities.Context;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using Surface.Common.Constants;
using Surface.DataAccessLayer.Repositories.Infrastructure;

namespace Surface.DataAccessLayer.Repositories.Architecture
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly SurfaceContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepo(SurfaceContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }
        public async Task AddAsync(T entity, CancellationToken cancellationToken = default) =>
            await _dbSet.AddAsync(entity, cancellationToken);

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default) =>
            await _dbSet.AddRangeAsync(entities, cancellationToken);

        public async Task<PageListResponseDTO<T>> GetAllAsync(PageListRequestEntity<T> pageListRequest, CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _dbSet.AsQueryable().AsNoTracking();

            if (pageListRequest.IncludeExpressions != null)
            {
                query = pageListRequest.IncludeExpressions.Aggregate(query, (current, include) =>
                {
                    return current.Include(include);
                });
            }

            if (pageListRequest.ThenIncludeExpressions != null)
            {
                query = pageListRequest.ThenIncludeExpressions.Aggregate(query, (current, thenInclude) =>
                {
                    return current.Include(thenInclude);
                });
            }

            query = pageListRequest.Predicate != null ?
                query.Where(pageListRequest.Predicate) :
                query;

            if (!string.IsNullOrEmpty(pageListRequest.SortColumn))
            {
                string sortExpression = pageListRequest.SortColumn.Trim();

                string sortOrder = pageListRequest.SortOrder.Trim().ToLower();

                if (string.IsNullOrEmpty(sortOrder) || !sortOrder.Equals(SystemConstant.ASCENDING))
                    sortOrder = SystemConstant.DESCENDING;

                string dynamicSortExpression = $"{sortExpression} {sortOrder}";

                query = query.OrderBy(dynamicSortExpression);
            }

            if (pageListRequest.Selects != null)
                query = query.Select(pageListRequest.Selects);

            int totalRecords = await query.CountAsync(cancellationToken);

            var records = await query
                .Skip((pageListRequest.PageIndex - 1) * pageListRequest.PageSize)
                .Take(pageListRequest.PageSize)
                .ToListAsync(cancellationToken);

            return new PageListResponseDTO<T>(pageListRequest.PageIndex, pageListRequest.PageSize, totalRecords, records);
        }


        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate)
        {
            if (predicate == null)
            {
                return await _dbSet.AsNoTracking().ToListAsync();
            }

            return await _dbSet.Where(predicate).AsNoTracking().ToListAsync();
        }


        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate, IEnumerable<Expression<Func<T, object>>> includes, string? sortColumn = null, string? sortOrder = null)
        {
            IQueryable<T> query = _dbSet.AsQueryable().AsNoTracking();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) =>
                {
                    return current.Include(include);
                });
            }

            query = predicate != null ? query.Where(predicate) : query;

            if (!string.IsNullOrEmpty(sortColumn))
            {
                string dynamicSortExpression = $"{sortColumn} {(sortOrder?.ToLower() == SystemConstant.DESCENDING ? SystemConstant.DESCENDING : SystemConstant.ASCENDING)}";

                query = query.OrderBy(dynamicSortExpression);
            }

            return await query.ToListAsync();
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>>[]? includes = null, string[]? thenIncludes = null, Expression<Func<T, T>>? selects = null, CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _dbSet.AsQueryable().AsNoTracking();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) =>
                {
                    return current.Include(include);
                });
            }

            if (thenIncludes != null)
            {
                query = thenIncludes.Aggregate(query, (current, thenInclude) =>
                {
                    return current.Include(thenInclude);
                });
            }

            query = query.Where(expression);

            if (selects != null)
                query = query.Select(selects);

            return await query.FirstOrDefaultAsync(cancellationToken);
        }



        public async Task<T> GetByIdAsync(dynamic id)
        {
            return await _dbSet.FindAsync(id);
        }

     

        public async Task<bool> IsEntityExist(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().AnyAsync(predicate);
        }

        public void Remove(T entity)
        {
            Update(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            UpdateRange(entities);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

    }
}
