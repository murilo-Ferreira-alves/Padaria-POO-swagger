using Senac.Padaria.Domain.Entidades;
using Senac.Padaria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class VendaViewModel
    {
        public Guid IdVenda { get; private set; }
        public decimal ValorFinal { get; private set; }
        public DateTime DataVenda { get; private set; }
        public Guid FuncionarioId { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public ItensVenda ItensVenda { get; private set; }

    }
}
