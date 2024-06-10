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
    public class enderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Nome da tabela 
            builder.ToTable("Endereco");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.Logradouro).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Complemento).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Bairro).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Cidade).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Estado).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Cep).HasMaxLength(200).IsRequired();

            builder.Property(p => p.TipoEndereco).HasMaxLength(200).IsRequired();
        }
    }
}
