using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TGInterview.Core.Base.Concrete;
using TGInterview.ProductService.Domain.Entities;

namespace TGInterview.ProductService.Infrastructure.Data.Context;

public class ProductDbContext : DbContext
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ProductDbContext(DbContextOptions<ProductDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        Guid currentUserId = Guid.Parse(_httpContextAccessor.HttpContext.User.FindFirst(x => x.Type == ClaimTypes.NameIdentifier)?.Value!);

        ChangeTracker.Entries().ToList().ForEach(e =>
        {
            BaseEntity baseEntity = (BaseEntity)e.Entity;

            switch (e.State)
            {
                case EntityState.Added:
                    baseEntity.CreatedDate = DateTime.Now;
                    baseEntity.IsActive = true;
                    break;
                case EntityState.Modified:
                    baseEntity.ModifiedDate = DateTime.Now;
                    break;
            }
        });

        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }
}