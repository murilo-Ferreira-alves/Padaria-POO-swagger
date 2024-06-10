using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IDocumentoGeraisRepository
    {
        DocumentosGerais GetById(Guid id);
        IEnumerable<DocumentosGerais> Busca(Expression<Func<DocumentosGerais, bool>> predicado);
        IEnumerable<DocumentosGerais> Busca(Expression<Func<DocumentosGerais, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
        DocumentosGerais Adicionar(DocumentosGerais entidade);
        DocumentosGerais Alterar(DocumentosGerais entidade);
        void Delete(Guid id);
        void Delete(Expression<Func<DocumentosGerais    , bool>> predicado);
    }
}
