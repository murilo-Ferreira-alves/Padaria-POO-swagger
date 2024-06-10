using Senac.Padaria.Core.ObjetosDominio;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Senac.Padaria.Domain.Interfaces
{
    public interface IVendaRepositories  
    {

        
        
            Venda GetById(Guid id);
            IEnumerable<Venda> Busca(Expression<Func<Venda, bool>> predicado);
            IEnumerable<Venda> Busca(Expression<Func<Venda, bool>> predicado,
                int numeroPagina,
                int tamanhoPagina);
            Venda Adicionar(Venda entidade);
            Venda Alterar(Venda entidade);
            void Delete(Guid id);
            void Delete(Expression<Func<Venda, bool>> predicado);
        
    }
}

