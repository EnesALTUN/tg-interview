using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TGInterview.Core.Base.Abstract;
using TGInterview.Core.Base.Concrete;
using TGInterview.ProductService.Infrastructure.Repository;

namespace TGInterview.ProductService.Infrastructure.UnitOfWork;

public interface IUnitOfWork : IAsyncDisposable
{
    IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity, IEntity;

    Task<int> SaveChangesAsync();

    Task<IDbContextTransaction> BeginTransactionAsync();

    Task CommitAsync(bool isSaveChanges = true);

    Task RollBackAsync();
}

public interface IUnitOfWork<TContext> : IUnitOfWork, IAsyncDisposable where TContext : DbContext
{
    TContext Context { get; }
}