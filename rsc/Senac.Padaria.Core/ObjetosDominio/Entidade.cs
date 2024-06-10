using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Core.ObjetosDominio
{
    public abstract class Entidade
    {
        protected Entidade()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }

        protected Guid SetId() 
        {
            Guid Id = Guid.NewGuid();
            return Id;
        }
        

    }
}
