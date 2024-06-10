using Senac.Padaria.Aplicantion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Interfaces
{
    public interface IEnderecoAppService
    {
        EnderecoViewModel Add(EnderecoViewModel endereco);
        EnderecoViewModel Update(EnderecoViewModel endereco);
        void Delete(Guid id);
        void Delete(Expression<Func<EnderecoViewModel, bool>> expression);
        IEnumerable<EnderecoViewModel> Buscar(Expression<Func<IEnderecoAppService, bool>> predicado);
        IEnumerable<EnderecoViewModel> Buscar(Expression<Func<IEnderecoAppService, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
    }
}
