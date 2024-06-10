using AutoMapper;
using MediatR;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;
using Senac.Padaria.Domain;
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
    public class FuncionarioAppService : BaseService, IFuncionarioAppService
    {
        protected readonly IFuncionarioRepository _repositorio;
        protected readonly IMapper _mapper;

        protected FuncionarioAppService(IFuncionarioRepository repositorio,
            IMapper mapper,
            IUnitOfWork uoW, 
            IMediator bus) : base(uoW, bus)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }
        public FuncionarioViewModel Add(FuncionarioViewModel viewModel)
        {
            Funcionario dominio = _mapper.Map<Funcionario>(viewModel);
            dominio = _repositorio.Adicionar(dominio);
            Commit();
            FuncionarioViewModel viewModelRetorno = _mapper.Map<FuncionarioViewModel>(viewModel);
            return viewModelRetorno;
        }

        public FuncionarioViewModel BuscaPorId(Guid id)
        {
            Funcionario dominio = _repositorio.GetById(id);
            FuncionarioViewModel viewModel = _mapper.Map<FuncionarioViewModel>(dominio);
            return viewModel;
        }

        public IEnumerable<FuncionarioViewModel> Buscar(Expression<Func<Funcionario, bool>> predicado)
        {
            IEnumerable<Funcionario> domain = _repositorio.Busca(predicado);
            IEnumerable<FuncionarioViewModel> viewModels = _mapper.Map<IEnumerable<FuncionarioViewModel>>(domain);
            return viewModels;
        }

        public IEnumerable<FuncionarioViewModel> Buscar(Expression<Func<Funcionario, bool>> predicado, int numeroPagina, int tamanhoPagina)
        {
            IEnumerable<Funcionario> domain = _repositorio.Busca(predicado, numeroPagina, tamanhoPagina);
            IEnumerable<FuncionarioViewModel> viewModels = _mapper.Map<IEnumerable<FuncionarioViewModel>>(domain);
            return viewModels;
        }

        public FuncionarioViewModel BuscarPorId(Guid id)
        {


            Funcionario dominio = _repositorio.GetById(id);
            FuncionarioViewModel viewModel = _mapper.Map<FuncionarioViewModel>(dominio);
            return viewModel; 
        }

        public void Delete(Guid id)
        {
            _repositorio.Delete(id);
            Commit();
        }

        public void Delete(Expression<Func<Funcionario, bool>> expression)
        {
            _repositorio.Delete(expression);
            Commit();
        }

        public FuncionarioViewModel Update(FuncionarioViewModel viewModel)
        {
            Funcionario dominio = _mapper.Map<Funcionario>(viewModel);
            dominio = _repositorio.Alterar(dominio);
            Commit();
            FuncionarioViewModel viewModelRetorno = _mapper.Map<FuncionarioViewModel>(dominio);
            return viewModelRetorno;
        }

        
    }
}
