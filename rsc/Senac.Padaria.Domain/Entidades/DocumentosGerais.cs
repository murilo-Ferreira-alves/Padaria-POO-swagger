using Senac.Padaria.Core.ObjetosDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Domain.Entidades
{
    
    public class DocumentosGerais : Entidade
    {
        public DocumentosGerais(Guid id,
            string cPF,
            string rG, 
            DateTime dataNacimento)
        {
            IdDocumento = SetId();
            CPF = cPF;
            RG = rG;
            DataNacimento = dataNacimento;
        }

        protected DocumentosGerais() { }  

        
        public Guid IdDocumento { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public DateTime DataNacimento { get; private set; }

         public void SetIdDocumento () 
        {
         
            IdDocumento = SetId(); 
            
        }
        public  void SetCpf (string cPF)
        {
            CPF = cPF;  
        }
        public void SetRg (string rG)
        {
            RG = rG;
        }
        public void SetDataNacimento (DateTime dataNacimento)
        {
            DataNacimento = dataNacimento;
        }



    }
}
