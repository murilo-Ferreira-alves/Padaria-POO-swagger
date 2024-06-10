using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class DocumentosGeraisViewModel
    {
        public Guid IdDocumento { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime DataNacimento { get; private set; }

    }
}
