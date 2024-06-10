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
    public class VendaMapeamento : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            //Nome da tabela 
            builder.ToTable("Venda");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.ValorFinal).HasMaxLength(200).IsRequired();

            builder.Property(p => p.DataVenda).HasMaxLength(200).IsRequired();

            builder.Property(p => p.FuncionarioId).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Funcionario).HasMaxLength(200).IsRequired();

        }
    }
}
