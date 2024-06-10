﻿using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entidade
    {

        long Count();
        long Count(Expression<Func<T, bool>> predicate);
    }
}
