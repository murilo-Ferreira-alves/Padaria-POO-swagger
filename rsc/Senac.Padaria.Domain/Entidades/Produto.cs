using Senac.Padaria.Core.Enum;
using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Entidades
{
    public class Produto : Entidade
    {
        protected Produto() { }

        public Produto(Guid idProduto,
            string nomeProduto,
            decimal preco, 
            TipoMedida medidaPreco,
            bool ativo)
        {
            IdProduto = SetId();
            NomeProduto = nomeProduto;
            Preco = preco;
            MedidaPreco = medidaPreco;
            Ativo = ativo;
        }

        public Guid IdProduto { get;  private set; }
        public string NomeProduto { get; private set; }
        public decimal Preco { get; private set; }
        public TipoMedida MedidaPreco { get; private set; }
        public bool Ativo { get; private set; }


        public void SetIdProduto()
        {
            IdProduto = SetId();    
        }
        public void SetNomeProduto(string nomeProduto)
        {
            NomeProduto = nomeProduto;
        }
        public void SetPreco(decimal preco)
        {
            Preco = preco;
        }
        public void SetAtivo(bool ativo)
        {
            Ativo = ativo;
        }
        public void SetTipoMedida(TipoMedida medidaPreco)
        {
            MedidaPreco = medidaPreco;
        }

    }
}
