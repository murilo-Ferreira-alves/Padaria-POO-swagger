using Microsoft.EntityFrameworkCore;
using Senac.Padaria.Infra.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Infra.Data.Context
{
    public class PadariaDbContext : DbContext
    {
        public PadariaDbContext(DbContextOptions<PadariaDbContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Todo: Aplicar configurações de mapeamento 
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new FuncionarioMapeamento());
            modelBuilder.ApplyConfiguration(new VendaMapeamento());
            base.OnModelCreating(modelBuilder);
        }

    }
}
