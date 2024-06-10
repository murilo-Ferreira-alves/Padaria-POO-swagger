using Senac.Padaria.Core.Enum;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class ItensVendaViewModel
    {

        public Guid IdItensVenda { get; private set; }
        public Guid ProdutoId { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public TipoMedida TipoMedida { get; private set; }
    }
}
