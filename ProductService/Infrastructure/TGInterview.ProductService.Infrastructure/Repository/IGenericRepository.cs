using System.Linq.Expressions;
using TGInterview.Core.Base.Abstract;

namespace TGInterview.ProductService.Infrastructure.Repository;

public interface IGenericRepository<TEntity> where TEntity : IEntity
{
    Task<TEntity> GetByIdAsync(Guid id);

    IQueryable<TEntity> GetAll();

    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

    Task AddAsync(TEntity entity);

    void Remove(TEntity entity);

    void Update(TEntity entity);
}