using Microsoft.EntityFrameworkCore;
using Senac.Padaria.Core.ObjetosDominio;
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
    public class Repository<T> : IRepository<T> where T : Entidade
    {
        protected readonly PadariaDbContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(PadariaDbContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        protected IQueryable<T> Query()
        {
            return DbSet;
        }

        public void Dispose()
        {
            Db?.Dispose();
            GC.SuppressFinalize(this);
        }

        public long Count()
        {
            return DbSet.LongCount();
        }

        public long Count(Expression<Func<T, bool>> predicate)
        {
            var resultado = DbSet.LongCount(predicate);
            return resultado;
        }
    }
}
