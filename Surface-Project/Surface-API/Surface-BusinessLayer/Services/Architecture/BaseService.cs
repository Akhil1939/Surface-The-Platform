using StudentJobs.Entities.DTOs;
using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using System.Linq.Expressions;
namespace Surface.BusinessAccessLayer.Services.Architecture;

public class BaseService<T> : IBaseService<T> where T : class
{
    private readonly IBaseRepo<T> _baseRepo;
    private readonly IUnitOfWork _unitOfWork;
    public BaseService(IBaseRepo<T> baseRepo, IUnitOfWork unitOfWork)
    {
        _baseRepo = baseRepo;
        _unitOfWork = unitOfWork;
    }
    public async Task AddAsync(T entity)
    {
        CancellationTokenSource cancellationTokenSource = new();
        CancellationToken cancellationToken = cancellationTokenSource.Token;
        await _baseRepo.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();
    }
    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        CancellationTokenSource cancellationTokenSource = new();
        CancellationToken cancellationToken = cancellationTokenSource.Token;
        await _baseRepo.AddRangeAsync(entities, cancellationToken);
        await _unitOfWork.SaveAsync();
    }
    public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[]? includes = null, string[]? thenIncludes = null, Expression<Func<T, T>>? selects = null)
    {
        return await _baseRepo.GetAsync(predicate, includes, thenIncludes, selects);
    }
    public async Task UpdateAsync(T entity)
    {
        _baseRepo.Update(entity);
        await _unitOfWork.SaveAsync();
    }
    public async Task UpdateRangeAsync(IEnumerable<T> entities)
    {
        _baseRepo.UpdateRange(entities);
        await _unitOfWork.SaveAsync();
    }

    //To Get List 
    public async Task<PageListResponseDTO<T>> GetAllAsync(PageListRequestEntity<T> pageListRequest)
    {
        return await _baseRepo.GetAllAsync(pageListRequest);
    }

    //To check is exist
    public async Task<bool> IsEntityExist(Expression<Func<T, bool>> predicate)
    {
        return await _baseRepo.IsEntityExist(predicate);
    }
}
