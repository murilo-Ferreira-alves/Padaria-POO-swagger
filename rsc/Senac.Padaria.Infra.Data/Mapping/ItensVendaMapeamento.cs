using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Infra.Data.Mapping
{
    public class ItensVendaMapeamento : IEntityTypeConfiguration<ItensVenda>
    {
        public void Configure(EntityTypeBuilder<ItensVenda> builder)
        {
            //Nome da tabela 
            builder.ToTable("ItensVenda");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.ProdutoId).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Produto).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Quantidade).HasMaxLength(200).IsRequired();

            builder.Property(p => p.TipoMedida).HasMaxLength(200).IsRequired();

        }
    }
}
