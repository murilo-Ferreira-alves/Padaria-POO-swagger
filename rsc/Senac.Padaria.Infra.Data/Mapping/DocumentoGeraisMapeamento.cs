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
    public class DocumentoGeraisMapeamento : IEntityTypeConfiguration<DocumentosGerais>
    {
        public void Configure(EntityTypeBuilder<DocumentosGerais> builder)
        {
            //Nome da tabela 
            builder.ToTable("DocumentosGerais");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.CPF).HasMaxLength(200).IsRequired();

            builder.Property(p => p.RG).HasMaxLength(200).IsRequired();

            builder.Property(p => p.DataNacimento).HasMaxLength(200).IsRequired();

        }
    }
}
