using Microsoft.EntityFrameworkCore;
using Senac.Padaria.Domain.Entidades;
using Senac.Padaria.Domain.Interfaces;
using Senac.Padaria.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Infra.Data.Repositories
{
    public class DocumentoGeraisRepository : Repository<DocumentosGerais>, IDocumentoGeraisRepository
    {
        public DocumentoGeraisRepository(PadariaDbContext context) : base(context)
        {
        }


        public DocumentosGerais Adicionar(DocumentosGerais entidade)
        {
            DbSet.Add(entidade);
            return entidade;
        }
        public DocumentosGerais Alterar(DocumentosGerais entidade)
        {
            DbSet.Update(entidade);
            return entidade;
        }
        public IEnumerable<DocumentosGerais > Busca(Expression<Func<DocumentosGerais, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.Where(predicado).ToList();

        }
        public IEnumerable<DocumentosGerais> Busca(Expression<Func<DocumentosGerais, bool>> predicado, int numeroPagina, int tamanhoPagina)
        {
            var contexto = DbSet.AsQueryable();
            var resultado = contexto.Where(predicado)
                .Skip((numeroPagina - 1) * tamanhoPagina)
                .Take(tamanhoPagina);
            return resultado;
        }
        public void Delete(Guid id)
        {
            var objeto = GetById(id);
            if (objeto != null)
            {
                DbSet.Remove(objeto);
            }

        }
        public void Delete(Expression<Func<DocumentosGerais, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            var entidades = contexto.Where(predicado);
            DbSet.RemoveRange(entidades);
        }
        public DocumentosGerais GetById(Guid id)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.FirstOrDefault(p => p.Id == id);
        }

    }
}
