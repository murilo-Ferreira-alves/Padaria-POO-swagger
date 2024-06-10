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
    public class ProdutoRepository : Repository<Produto>,IProdutoRepository
    {
        public ProdutoRepository(PadariaDbContext context) : base(context)
        {
        }

        public Produto Adicionar(Produto entidade)
        {
            DbSet.Add(entidade);
            return entidade;
        }
        public Produto Alterar (Produto entidade)
        {
            DbSet.Update(entidade);
            return entidade;
        }
        public IEnumerable<Produto> Busca(Expression<Func<Produto,bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.Where(predicado).ToList();

        }
        public IEnumerable<Produto> Busca(Expression<Func<Produto, bool>> predicado, int numeroPagina, int tamanhoPagina)
        {
            var contexto = DbSet.AsQueryable();
            var resultado = contexto.Where(predicado)
                .Skip((numeroPagina - 1) * tamanhoPagina)
                .Take(tamanhoPagina);
            return resultado;
        }
        public void Delete(Guid id )
        {
            var objeto = GetById(id);
            if (objeto != null)
            {
                DbSet.Remove(objeto);
            }

        }
        public void Delete(Expression<Func<Produto, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            var entidades = contexto.Where(predicado);
            DbSet.RemoveRange(entidades);
        }
        public Produto GetById(Guid id)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.FirstOrDefault(p => p.Id == id);
        }

          

    }
}
