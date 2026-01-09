using Catalog.Common.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Common;

public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
    where TEntity : class
    where TContext : DbContext
{
    protected readonly TContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public BaseRepository(TContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public virtual async Task<TEntity?> GetByIdAsync(string id, CancellationToken cancellationToken = default)
        => await _dbSet.FindAsync(new object[] { id }, cancellationToken);

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        => await _dbSet.ToListAsync(cancellationToken);

    public IQueryable<TEntity> GetAllAsNoTracking()
        => _dbSet.AsNoTracking();

    public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        => await _dbSet.AddAsync(entity, cancellationToken);

    public virtual void Update(TEntity entity)
        => _dbSet.Update(entity);

    public virtual void Delete(TEntity entity)
        => _dbSet.Remove(entity);

    public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => await _context.SaveChangesAsync(cancellationToken);

    public void Dispose()
        => _context?.Dispose();
}