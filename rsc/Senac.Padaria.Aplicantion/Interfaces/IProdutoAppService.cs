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
    public interface IProdutoAppService
    {
        ProdutoViewModel Add(ProdutoViewModel produto);
        ProdutoViewModel Update(ProdutoViewModel produto);
        void Delete(Guid id);
        void Delete(Expression<Func<Produto, bool>> expression);
        IEnumerable<ProdutoViewModel> Buscar(Expression<Func<Produto, bool>> predicado);
        IEnumerable<ProdutoViewModel> Buscar(Expression<Func<Produto, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        ProdutoViewModel GetById(Guid id);
    }
}
