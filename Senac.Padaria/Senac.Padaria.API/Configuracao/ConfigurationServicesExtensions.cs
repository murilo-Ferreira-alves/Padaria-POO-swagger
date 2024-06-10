using Microsoft.EntityFrameworkCore;
using Senac.Padaria.Infra.Data.Context;

namespace Senac.Padaria.API.Configuracao
{
    public static class ConfigurationServicesExtensions
    {
        public static IServiceCollection DbContextConfigureServices
          (this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PadariaDbContext>(options => options.UseSqlServer(connectionString));

            services.AddDistributedMemoryCache();

            return services;

        }
    }
}
