namespace Catalog.Common.Abstractions;

public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
{
    Task<TEntity?> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);

    IQueryable<TEntity> GetAllAsNoTracking();

    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    void Update(TEntity entity);
    void Delete(TEntity entity);

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}