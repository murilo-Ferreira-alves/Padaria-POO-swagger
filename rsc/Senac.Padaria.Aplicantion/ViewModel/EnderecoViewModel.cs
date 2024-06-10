using Senac.Padaria.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class EnderecoViewModel
    {
        public Guid IdEndereco { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }
        public TipoEndereco TipoEndereco { get; private set; }
    }
}
