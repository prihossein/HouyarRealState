


using HouyarRealState.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HouyarRealState.Infrastructure.Middlewares
{
    public static class DatabaseMiddleware
    {
        public static async Task ApplyMigrationsAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetService<ApplicationDbContext>();
            if (context != null)
            {
                var pendingMigrations = await context.Database.GetPendingMigrationsAsync();
                if (pendingMigrations?.Any() == true)
                {
                    await context.Database.MigrateAsync();
                }


                context.Seed();
                

            }
        }
    }
}
