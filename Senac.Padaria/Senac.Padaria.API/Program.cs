
using Senac.Padaria.API.Configuracao;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureSerilog();
builder.Services.ConfigureStartupConfiguration(builder.Configuration);
var app = builder.Build().UseStartupConfiguration();

app.Run();
