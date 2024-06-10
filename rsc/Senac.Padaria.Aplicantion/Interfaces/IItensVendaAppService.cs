using Senac.Padaria.Aplicantion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Interfaces
{
    public interface IItensVendaAppService
    {
        ItensVendaViewModel Add(ItensVendaViewModel itensVenda);
        ItensVendaViewModel Update(ItensVendaViewModel itensVenda);
        void Delete(Guid id);
        void Delete(Expression<Func<ItensVendaViewModel, bool>> expression);
        IEnumerable<ItensVendaViewModel> Buscar(Expression<Func<IItensVendaAppService, bool>> predicado);
        IEnumerable<ItensVendaViewModel> Buscar(Expression<Func<IItensVendaAppService, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
    }
}
