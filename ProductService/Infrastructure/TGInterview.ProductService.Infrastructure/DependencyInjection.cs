using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TGInterview.ProductService.Infrastructure.Data.Context;
using TGInterview.ProductService.Infrastructure.Extensions;

namespace TGInterview.ProductService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProductDbContext>(options =>
            options.UseSqlServer(configuration.GetValue<string>("ProductSqlConnection"), mig => mig.MigrationsAssembly("TGInterview.ProductService.Api")));

        services.AddUnitOfWork<ProductDbContext>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}