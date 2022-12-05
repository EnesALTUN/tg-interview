using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TGInterview.ProductService.Infrastructure.UnitOfWork;

namespace TGInterview.ProductService.Infrastructure.Extensions;

internal static class UnitOfWorkServiceCollectionExtensions
{
    public static IServiceCollection AddUnitOfWork<TContext>(this IServiceCollection services) where TContext : DbContext
    {
        services.AddScoped<IUnitOfWork, UnitOfWork<TContext>>();
        services.AddScoped<IUnitOfWork<TContext>, UnitOfWork<TContext>>();

        return services;
    }
}