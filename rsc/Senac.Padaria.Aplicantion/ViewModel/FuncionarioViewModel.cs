using Senac.Padaria.Core.Enum;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.ViewModel
{
    public class FuncionarioViewModel
    {
        public Guid IdFuncionario { get;  set; }
        [Required(ErrorMessage = "O campo nome é obrigatorio")]
        [MaxLength(100, ErrorMessage = "O tamanho do campo é maior que o permitido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Sobrenome é obrigatorio")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O campo sexo é obrigatorio")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "O campo cargo é obrigatorio")]
        public TipoCargo Cargo { get; set; }
        [Required(ErrorMessage = "O campo documento é obrigatorio")]
        public DocumentosGerais Documento { get; set; }
        public Guid DocumentoId { get; set; }
        [Required(ErrorMessage = "O campo endereco é obrigatorio")]
        public Endereco EnderecoFuncionario { get;  set; }
        public Guid EnderecoId { get; set; }
    }
}
