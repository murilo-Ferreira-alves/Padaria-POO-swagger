using Senac.Padaria.Aplicantion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Interfaces
{
    public interface IDocumentosGeraisAppService
    {
        DocumentosGeraisViewModel Add(DocumentosGeraisViewModel documentosGerais);
        DocumentosGeraisViewModel Update(DocumentosGeraisViewModel documentosGerais);
        void Delete(Guid id);
        void Delete(Expression<Func<DocumentosGeraisViewModel, bool>> expression);
        IEnumerable<DocumentosGeraisViewModel> Buscar(Expression<Func<IDocumentosGeraisAppService, bool>> predicado);
        IEnumerable<DocumentosGeraisViewModel> Buscar(Expression<Func<IDocumentosGeraisAppService, bool>> predicado,
            int numeroPagina,
            int tamanhoPagina);
    }
}
