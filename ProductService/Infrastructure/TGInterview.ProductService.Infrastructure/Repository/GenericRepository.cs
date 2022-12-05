using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TGInterview.Core.Base.Abstract;
using TGInterview.Core.Base.Concrete;

namespace TGInterview.ProductService.Infrastructure.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, IEntity
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _dbSet = _context.Set<TEntity>();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity is not null)
            _context.Entry(entity).State = EntityState.Detached;

        return entity;
    }

    public IQueryable<TEntity> GetAll()
    {
        var query = _dbSet.AsNoTracking();

        query = query.OrderByDescending(x => x.CreatedDate);

        return query;
    }

    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbSet.Where(predicate);
    }

    public async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _dbSet.AnyAsync(predicate);
    }
}