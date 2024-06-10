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
    public class EnderecoRepository : Repository<Endereco>,IEnderecoRepository
    {
        public EnderecoRepository(PadariaDbContext context) : base(context)
        {
        }


        public Endereco Adicionar(Endereco entidade)
        {
            DbSet.Add(entidade);
            return entidade;
        }
        public Endereco Alterar(Endereco entidade)
        {
            DbSet.Update(entidade);
            return entidade;
        }
        public IEnumerable<Endereco> Busca(Expression<Func<Endereco, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.Where(predicado).ToList();

        }
        public IEnumerable<Endereco> Busca(Expression<Func<Endereco, bool>> predicado, int numeroPagina, int tamanhoPagina)
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
        public void Delete(Expression<Func<Endereco, bool>> predicado)
        {
            var contexto = DbSet.AsQueryable();
            var entidades = contexto.Where(predicado);
            DbSet.RemoveRange(entidades);
        }
        public Endereco GetById(Guid id)
        {
            var contexto = DbSet.AsQueryable();
            return contexto.FirstOrDefault(p => p.Id == id);
        }

    }
}
