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
    public class ProdutoAppService : BaseService, IProdutoAppService
    {
        protected readonly IProdutoRepository _repositorio;
        protected readonly IMapper _mapper;

        public ProdutoAppService(IProdutoRepository repositorio,
            IMapper mapper,
            IMediator bus,
            IUnitOfWork unitOfWork) : base(unitOfWork, bus)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }
        public ProdutoViewModel GetById(Guid id)
        {
            Produto dominio = _repositorio.GetById(id);
            ProdutoViewModel viewModel = _mapper.Map<ProdutoViewModel>(dominio);
            return viewModel;
        }
        public ProdutoViewModel Add(ProdutoViewModel viewModel)
        {
            Produto dominio = _mapper.Map<Produto>(viewModel);
            dominio = _repositorio.Adicionar(dominio);
            Commit();
            ProdutoViewModel viewModelRetorno = _mapper.Map<ProdutoViewModel>(viewModel);
            return viewModelRetorno;
        }

        public ProdutoViewModel Update(ProdutoViewModel viewModel)
        {
            Produto dominio = _mapper.Map<Produto>(viewModel);
            dominio = _repositorio.Alterar(dominio);
            Commit();
            ProdutoViewModel viewModelRetorno = _mapper.Map<ProdutoViewModel>(dominio);
            return viewModelRetorno;
        }

        public void Delete(Guid id)
        {
            _repositorio.Delete(id);
            Commit();
        }

        public void Delete(Expression<Func<Produto, bool>> expression)
        {
            _repositorio.Delete(expression);
            Commit();

        }

        public IEnumerable<ProdutoViewModel> Buscar(Expression<Func<Produto, bool>> predicado)
        {
            IEnumerable<Produto> dominio = _repositorio.Busca(predicado);
            IEnumerable<ProdutoViewModel> viewModels = _mapper.Map<IEnumerable<ProdutoViewModel>>(dominio);
            return viewModels;
        }

        public IEnumerable<ProdutoViewModel> Buscar(Expression<Func<Produto, bool>> predicado, int numeroPagina, int tamanhoPagina)
        {
            IEnumerable<Produto> dominio = _repositorio.Busca(predicado, numeroPagina, tamanhoPagina);
            IEnumerable<ProdutoViewModel> viewModels = _mapper.Map<IEnumerable<ProdutoViewModel>>(dominio);
            return viewModels;

        }

       

        
    }
}
