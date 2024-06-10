using Senac.Padaria.Core.Enum;
using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Entidades
{
    public class CupomDesconto : Entidade
    {
        protected CupomDesconto() { }

        public decimal Valor {  get; private set; }
        public bool Ativo { get; private set; }
        public TipoDesconto tipoDesconto { get; private set; }
    }
}
