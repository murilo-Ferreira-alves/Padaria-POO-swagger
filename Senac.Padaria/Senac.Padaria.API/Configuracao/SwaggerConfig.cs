using Microsoft.OpenApi.Models;

namespace Senac.Padaria.API.Configuracao
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Padaria Api",
                    Description = "Essa API é feita como parte do curos de Programador de Sistema do SENAC",
                    Contact = new OpenApiContact()
                    {
                        Name = "sistemasGO",
                        Email = "sistemasGO@gmail.com"
                    }
                });
            });
        }
        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("swagger/v1/swagger.json", "v1");
            });
        }
    }
}
