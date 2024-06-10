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
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {

        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //Nome da tabela 
            builder.ToTable("Produto");
            //Definir o tamanho máximo em 100 e que ele é obrigatório 
            builder.Property(p => p.NomeProduto).HasMaxLength(100).IsRequired();
            //Definir o tamanho máximo em 250
            builder.Property(p => p.MedidaPreco).HasMaxLength(250);
            //Definir que o valor padrão vai ser true caso não envie
            builder.Property(p => p.Ativo).HasDefaultValue(true);
            //Definir que a precisão do campo vai ser 10,2 e é obrigatório
            builder.Property(p => p.Preco).HasPrecision(10, 2).IsRequired();
           
          
        }

    }
}
