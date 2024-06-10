using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IItensVendaRepository
    {
        ItensVenda GetById(Guid id);
        IEnumerable<ItensVenda> Busca(Expression<Func<ItensVenda, bool>> predicado);
        IEnumerable<ItensVenda> Busca(Expression<Func<ItensVenda, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        ItensVenda Adicionar(ItensVenda entidade);
        ItensVenda Alterar( ItensVenda entidade);
        void Delete(Guid id);
        void Delete(Expression<Func<ItensVenda, bool>> predicado);
    }
}
