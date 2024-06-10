using Serilog;

namespace Senac.Padaria.API.Configuracao
{
    public static class ApiConfig
    {
        public static void ConfigureStartupConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(c => c.AddPolicy("MinhaPolitica", policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            services.AddControllers();
            services.RegisterServices();

            services.AddSwaggerGen();
            services.AddHttpContextAccessor();
            services.AddAutoMapper(AppDomain.CurrentDomain.Load("Senac.Padaria.Aplicantion"));
            services.Configure<IISServerOptions>(options =>
            {
                options.AllowSynchronousIO = true;
            });
        }

        public static WebApplication UseStartupConfiguration(this WebApplication app)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("MyPolicy");

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();
            return app;
        }

        public static void ConfigureSerilog(this ConfigureHostBuilder builder)
        {
            builder.UseSerilog((ctx, lc) => lc.WriteTo.Console());
        }
    }
}
