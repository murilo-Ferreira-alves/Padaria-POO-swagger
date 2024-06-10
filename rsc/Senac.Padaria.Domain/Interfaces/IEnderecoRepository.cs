using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        Endereco GetById(Guid id);
        IEnumerable<Endereco> Busca(Expression<Func<Endereco, bool>> predicado);
        IEnumerable<Endereco> Busca(Expression<Func<Endereco, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        Endereco Adicionar(Endereco entidade);
        Endereco Alterar(Endereco entidade);
        void Delete(Guid id);
        void Delete(Expression<Func<Endereco, bool>> predicado);
    }
}
