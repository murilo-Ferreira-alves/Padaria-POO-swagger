using Senac.Padaria.Core.Enum;
using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Entidades
{
    public class ItensVenda : Entidade
    {
        

        protected ItensVenda () { }

        public ItensVenda(Guid idItensVenda,
            Guid produtoId,
            Produto produto,
            int quantidade, 
            TipoMedida tipoMedida)
        {
            IdItensVenda = idItensVenda;
            ProdutoId = produtoId;
            Produto = produto;
            Quantidade = quantidade;
            TipoMedida = tipoMedida;
        }

        public Guid IdItensVenda { get; private set; }
        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public TipoMedida TipoMedida { get; private set; }

        public ItensVenda(List<ItensVenda> itens)
        {
            Itens = itens;
        }
        public decimal ValorFinal()
        {
            return Quantidade * Produto.Preco;
        }
        public void SetIdItensVenda (Guid idItensVenda)
        {
            IdItensVenda = idItensVenda;
        }
        public void SetProduto(Produto produto)
        {
            Produto = produto;

        }
        public void SetQuantidade(int quantidade)
        {
            Quantidade = quantidade;

        }
        public void SetTipoMedida(TipoMedida tipomedida)
        {
            TipoMedida = tipomedida;
          
        }

        public List<ItensVenda> Itens { get; private set; }

        public void AddItem(ItensVenda item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(ItensVenda item)
        {
            Itens.Remove(item);
        }
        public void AlteraQuantidadeItem(ItensVenda item, int novaQuantidade)
        {
            ItensVenda itemEncontrado = Itens.Where(i => i.Id == item.Id).First();
            itemEncontrado.SetQuantidade(novaQuantidade);
        }


    }
}
