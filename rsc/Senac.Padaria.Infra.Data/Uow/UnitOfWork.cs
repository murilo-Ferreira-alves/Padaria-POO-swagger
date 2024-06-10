using Senac.Padaria.Domain.Shared.Transacao;
using Senac.Padaria.Infra.Data.Context;

namespace Senac.Padaria.Infra.Data.Uow
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly PadariaDbContext _context;
        public UnitOfWork(PadariaDbContext context)
        {
            _context = context;
        }
        public bool Commit()
        {
            return _context.SaveChanges() > 0;

        }
    }
}
