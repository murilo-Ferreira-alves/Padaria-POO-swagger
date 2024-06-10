using MediatR;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.Servicos;
using Senac.Padaria.Domain.Interfaces;
using Senac.Padaria.Domain.Shared.Transacao;
using Senac.Padaria.Infra.Data.Context;
using Senac.Padaria.Infra.Data.Repositories;
using Senac.Padaria.Infra.Data.Uow;

namespace Senac.Padaria.API.Configuracao
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            AddMediatr(services);
            AddRepositories(services);
            AddServices(services);
        }

        public static void AddMediatr(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.Load("Senac.Padaria.Domain"));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<PadariaDbContext>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IDocumentoGeraisRepository, DocumentoGeraisRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IItensVendaRepository, ItensVendaRepository>();
            services.AddScoped<IVendaRepositories, VendaRepositories>();
        }

        public static void AddServices(this IServiceCollection services)
        {

            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IVendaAppService, VendaAppService>();
            services.AddScoped<IFuncionarioAppService, FuncionarioAppService>();

        }
    }
}
