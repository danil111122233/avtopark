using Avtopark.DataAccess;
using Avtopark.WebApi.Settings;
using Microsoft.EntityFrameworkCore;

namespace Avtopark.WebApi.IoC
{
    public class DbContextConfigurator
    {
        public static void ConfigureService(IServiceCollection services, AvtoparkSettings settings)
        {
            services.AddDbContextFactory<AvtoparkDbContext>(
                options => { options.UseSqlServer(settings.AvtoparkDbContextConnectionString); },
                ServiceLifetime.Scoped);
        }

        public static void ConfigureApplication(IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AvtoparkDbContext>>();
            using var context = contextFactory.CreateDbContext();
            context.Database.Migrate();
        }
    }
}
