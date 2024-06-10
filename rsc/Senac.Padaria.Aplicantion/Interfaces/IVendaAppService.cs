using Senac.Padaria.Aplicantion.ViewModel;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Interfaces
{
    public interface IVendaAppService
    {
        VendaViewModel Add(VendaViewModel venda);

        VendaViewModel Update(VendaViewModel venda);
        void Delete(Guid id);
        void Delete(Expression<Func<Venda, bool>> expression);
        IEnumerable<VendaViewModel> Buscar(Expression<Func<Venda, bool>> predicado);
        IEnumerable<VendaViewModel> Buscar(Expression<Func<Venda, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
       VendaViewModel GetById(Guid id);
    }
}
