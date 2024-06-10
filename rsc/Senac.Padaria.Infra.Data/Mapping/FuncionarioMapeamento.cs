using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Senac.Padaria.Domain;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Infra.Data.Mapping
{
    public class FuncionarioMapeamento : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //Nome da tabela 
            builder.ToTable("Funcionario");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.Nome).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Sobrenome).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Sexo).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Cargo).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Documento).HasMaxLength(200).IsRequired();

            builder.Property(p => p.DocumentoId).HasMaxLength(200).IsRequired();

            builder.Property(p => p.EnderecoFuncionario).HasMaxLength(200).IsRequired();

            builder.Property(p => p.EnderecoId).HasMaxLength(200).IsRequired();

        }
    }
}
