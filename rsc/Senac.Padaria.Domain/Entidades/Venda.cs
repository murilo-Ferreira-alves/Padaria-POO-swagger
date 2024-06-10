using Senac.Padaria.Core.Enum;
using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Entidades
{
    public class Venda : Entidade
    {
        public Venda(Guid idVenda,
            decimal valorFinal,
            DateTime dataVenda,
            Funcionario funcionario, ItensVenda itensVenda)
        {
            IdVenda = idVenda;
            ValorFinal = valorFinal;
            DataVenda = dataVenda;
            FuncionarioId = funcionario.Id;
            Funcionario = funcionario;
            ItensVenda = itensVenda;

        }

        protected Venda() { }

        public Guid IdVenda { get; private set; }
        public decimal ValorFinal { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Guid FuncionarioId { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public ItensVenda ItensVenda { get; private set; }

    

        public void SetValorFinal(decimal valorFinal)
        {
            ValorFinal = valorFinal;
        }
        public void SetDataVenda(DateTime dataVenda)
        {
            DataVenda = dataVenda;
        }
        public void SetFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;
            FuncionarioId = funcionario.Id;
        }
        public void SetItensVenda(ItensVenda itensVenda)
        {
            ItensVenda = itensVenda;


        }
       


    }
}
