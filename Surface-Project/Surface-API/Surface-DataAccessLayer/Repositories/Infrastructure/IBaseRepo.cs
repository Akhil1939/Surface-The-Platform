﻿using StudentJobs.Entities.DTOs;
using System.Linq.Expressions;


namespace Surface.DataAccessLayer.Repositories.Infrastructure
{
    public interface IBaseRepo<T> where T : class
    {

        Task<T?> GetAsync(Expression<Func<T, bool>> expression, Expression<Func<T, object>>[]? includes = null, string[]? thenIncludes = null, Expression<Func<T, T>>? selects = null, CancellationToken cancellationToken = default);

        Task<PageListResponseDTO<T>> GetAllAsync(PageListRequestEntity<T> pageListRequest, CancellationToken cancellationToken = default);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate, IEnumerable<Expression<Func<T, object>>> includes, string? sortColumn = null, string? sortOrder = null);

        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        Task<T> GetByIdAsync(dynamic id);

        Task<bool> IsEntityExist(Expression<Func<T, bool>> predicate);

    }
}
