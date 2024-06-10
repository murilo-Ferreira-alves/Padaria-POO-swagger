using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Produto GetById(Guid id);
        IEnumerable<Produto> Busca(Expression<Func<Produto, bool>> predicado);
        IEnumerable<Produto> Busca(Expression<Func<Produto, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        Produto Adicionar(Produto entidade);
        Produto Alterar(Produto entidade);
        void Delete(Guid id);
        void Delete(Expression<Func<Produto, bool>> predicado);
    }
}
