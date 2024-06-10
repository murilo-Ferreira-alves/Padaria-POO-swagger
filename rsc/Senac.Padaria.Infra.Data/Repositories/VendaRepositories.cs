﻿using Senac.Padaria.Domain.Entidades;
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
    public class VendaRepositories : Repository<Venda>, IVendaRepositories
    {
       
            public VendaRepositories (PadariaDbContext context) : base(context)
            {
            }


            public Venda Adicionar(Venda entidade)
            {
                DbSet.Add(entidade);
                return entidade;
            }
            public Venda Alterar(Venda entidade)
            {
                DbSet.Update(entidade);
                return entidade;
            }
            public IEnumerable<Venda> Busca(Expression<Func<Venda, bool>> predicado)
            {
                var contexto = DbSet.AsQueryable();
                return contexto.Where(predicado).ToList();

            }
            public IEnumerable<Venda> Busca(Expression<Func<Venda, bool>> predicado, int numeroPagina, int tamanhoPagina)
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
            public void Delete(Expression<Func<Venda, bool>> predicado)
            {
                var contexto = DbSet.AsQueryable();
                var entidades = contexto.Where(predicado);
                DbSet.RemoveRange(entidades);
            }
            public Venda GetById(Guid id)
            {
                var contexto = DbSet.AsQueryable();
                return contexto.FirstOrDefault(p => p.Id == id);
            }



        
    }
}
