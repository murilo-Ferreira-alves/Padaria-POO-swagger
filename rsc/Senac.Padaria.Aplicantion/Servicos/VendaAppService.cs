using AutoMapper;
using MediatR;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;
using Senac.Padaria.Domain.Entidades;
using Senac.Padaria.Domain.Interfaces;
using Senac.Padaria.Domain.Shared.Transacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senac.Padaria.Aplicantion.Servicos
{
    public class VendaAppService : BaseService,IVendaAppService
    {
        protected readonly IVendaRepositories _repositories;
        protected readonly IMapper _mapper;
        protected VendaAppService(IVendaRepositories repositories,
            Mapper mapper,
            IUnitOfWork uoW,
            IMediator bus) : base(uoW, bus)
        {
            _repositories = repositories;
            _mapper = mapper;
        }

        public VendaViewModel GetById(Guid id)
        {
            Venda dominio = _repositories.GetById(id);
            VendaViewModel viewModel = _mapper.Map<VendaViewModel>(dominio);
            return viewModel;
        }

        public VendaViewModel Add(VendaViewModel viewModel)
        {
            Venda dominio = _mapper.Map<Venda>(viewModel);
            dominio = _repositories.Adicionar(dominio);
            Commit();
            VendaViewModel viewModelRetorno = _mapper.Map<VendaViewModel>(viewModel);
            return viewModelRetorno;
        }

        public IEnumerable<VendaViewModel> Buscar(Expression<Func<Venda, bool>> predicado)
        {
            IEnumerable<Venda> domain = _repositories.Busca(predicado);
            IEnumerable<VendaViewModel> viewModels = _mapper.Map<IEnumerable<VendaViewModel>>(domain);
            return viewModels;
        }

        public IEnumerable<VendaViewModel> Buscar(Expression<Func<Venda , bool>> predicado, int numeroPagina, int tamanhoPagina)
        {
            IEnumerable<Venda> domain = _repositories.Busca(predicado, numeroPagina, tamanhoPagina);
            IEnumerable<VendaViewModel> viewModels = _mapper.Map<IEnumerable<VendaViewModel>>(domain);
            return viewModels;
        }

       

       
        public void Delete(Guid id)
        {
            _repositories.Delete(id);
            Commit();
        }

        public void Delete(Expression<Func<Venda, bool>> expression)
        {
            _repositories.Delete(expression);
            Commit();
        }

       
        public VendaViewModel Update(VendaViewModel viewModel)
        {
            Venda dominio = _mapper.Map<Venda>(viewModel);
            dominio = _repositories.Alterar(dominio);
            Commit();
            VendaViewModel viewModelRetorno = _mapper.Map<VendaViewModel>(dominio);
            return viewModelRetorno;
        }
    }
}
