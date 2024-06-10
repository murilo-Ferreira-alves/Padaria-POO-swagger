using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Shared.Transacao
{
    public interface IUnitOfWork
    {
        bool Commit();
    }
}
