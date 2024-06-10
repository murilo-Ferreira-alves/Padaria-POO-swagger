using Microsoft.EntityFrameworkCore;
using Senac.Padaria.Domain;
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
    public class ItensVendaRepository : Repository<ItensVenda>, IItensVendaRepository
    {
        public ItensVendaRepository(PadariaDbContext context) : base(context)
        {
        }

        public ItensVenda Adicionar(ItensVenda entidade)
        {
            DbSet.Add(entidade);
            return entidade;
        }
        public ItensVenda Alterar( ItensVenda entidade)
        {
            DbSet.Update(entidade);
            return entidade;
        }
        public IEnumerable<ItensVenda> Busca(Expression<Func<ItensVenda, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.Where(predicado).ToList();

        }
        public IEnumerable<ItensVenda> Busca(Expression<Func<ItensVenda, bool>> predicado, int numeroPagina, int tamanhoPagina)
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
        public void Delete(Expression<Func<ItensVenda, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            var entidades = contexto.Where(predicado);
            DbSet.RemoveRange(entidades);
        }
        public ItensVenda GetById(Guid id)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.FirstOrDefault(p => p.Id == id);
        }
    }
}
