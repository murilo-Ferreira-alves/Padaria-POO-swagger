using Senac.Padaria.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class ProdutoViewModel
    {
        public Guid IdProduto { get; private set; }
        [Required(ErrorMessage = "O campo nomeProduto é obrigatorio")]
        public string NomeProduto { get; private set; }
        [Required(ErrorMessage = "O campo preço é obrigatorio")]
        public decimal Preco { get; private set; }
        public TipoMedida MedidaPreco { get; private set; }
        public bool Ativo { get; private set; }

    }
}
