using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        Funcionario GetById(Guid id);
        IEnumerable<Funcionario> Busca(Expression<Func<Funcionario, bool>> predicado);
        IEnumerable<Funcionario> Busca(Expression<Func<Funcionario, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        Funcionario Adicionar(Funcionario entidade);
        Funcionario Alterar(Funcionario entidade);
        void Delete(Guid id);
        void Delete(Expression<Func<Funcionario, bool>> predicado);
       
    }
}
