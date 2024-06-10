using Senac.Padaria.Core.Enum;
using Senac.Padaria.Core.ObjetosDominio;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain
{
    public class Funcionario : Entidade
    {
        public Funcionario(Guid idFuncionario,
            string nome,
            string sobrenome,
            string sexo,
            TipoCargo cargo,
            DocumentosGerais documento,
            Endereco enderecoFuncionario)
        {
            IdFuncionario = SetId(); 
            Nome = nome;
            Sobrenome = sobrenome;
            Sexo = sexo;
            Cargo = cargo;
            Documento = documento;
            EnderecoFuncionario = enderecoFuncionario;
        }

        protected Funcionario () { }   
        
        public Guid IdFuncionario { get;  private set; }

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }
        public string Sexo { get; private set; }

        public TipoCargo Cargo { get; private set; }

        public DocumentosGerais Documento {  get; private set; }
        public Guid DocumentoId {  get; private set; }
        public Endereco EnderecoFuncionario { get; private set; }
        public Guid EnderecoId {  get; private set; }   

        public void SetIdFuncionario ()
        {
            IdFuncionario = SetId();    
        }
        public void SetEndeco(Endereco enderecoFuncionario)
        {
            EnderecoFuncionario = enderecoFuncionario;
            EnderecoId = enderecoFuncionario.Id;
        }
        public void SetDocumentoGerais (DocumentosGerais documento)
        {
            Documento = documento;
            DocumentoId = documento.Id;
        }
        public void SetTipoCargo (TipoCargo cargo)
        {
            Cargo = cargo;
        }
        public void SetNome (string nome)
        {
            Nome = nome;
        }
        public void SetSobreNome (string sobreNome)
        {
            Sobrenome = sobreNome;
        }
        public void SetSexo (string sexo)
        {
            Sexo = sexo;
        }
        







    }
}
