using Microsoft.EntityFrameworkCore;
using TGInterview.ProductService.Infrastructure.Data.Context;

namespace TGInterview.ProductService.Api.Extensions;

public static class AutoDatabaseMigrate
{
    public static WebApplication ApplyMigration (this WebApplication app)
    {
        using(var serviceScope = app.Services.CreateScope())
        {
            var db = serviceScope.ServiceProvider.GetRequiredService<ProductDbContext>();

            db.Database.MigrateAsync().GetAwaiter().GetResult();
        }

        return app;
    }
}