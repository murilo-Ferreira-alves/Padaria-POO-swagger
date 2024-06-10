using Senac.Padaria.Aplicantion.ViewModel;
using Senac.Padaria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Interfaces
{
    public interface IFuncionarioAppService
    {
        FuncionarioViewModel Add(FuncionarioViewModel funcionario);
        FuncionarioViewModel Update(FuncionarioViewModel funcionario);
        void Delete(Guid id);
        void Delete(Expression<Func<Funcionario, bool>> expression);
        IEnumerable<FuncionarioViewModel> Buscar(Expression<Func<Funcionario, bool>> predicado);
        IEnumerable<FuncionarioViewModel> Buscar(Expression<Func<Funcionario, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        FuncionarioViewModel BuscaPorId(Guid id);
    }
}
