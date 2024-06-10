using AutoMapper;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;
using Senac.Padaria.Domain;
using Senac.Padaria.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>()
                .ReverseMap();

            CreateMap<DocumentosGerais, DocumentosGeraisViewModel>()
               .ReverseMap();

            CreateMap<Endereco, EnderecoViewModel>()
               .ReverseMap();

            CreateMap<Funcionario, FuncionarioViewModel>()
               .ReverseMap();

            CreateMap<ItensVenda, ItensVendaViewModel>()
               .ReverseMap();

            CreateMap<Venda, VendaViewModel>()
               .ReverseMap();
        }

    }
}
