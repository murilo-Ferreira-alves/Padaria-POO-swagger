using Microsoft.AspNetCore.Mvc;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;

namespace Senac.Padaria.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioAppService _funcionarioAppService;

        public FuncionarioController(IFuncionarioAppService funcionarioAppService)
        {
            _funcionarioAppService = funcionarioAppService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var resultado = _funcionarioAppService.Buscar(p => true);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public ActionResult<FuncionarioViewModel> Get(Guid id)
        {
            var resultado = _funcionarioAppService.BuscaPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public ActionResult Post([FromBody] FuncionarioViewModel model)
        {
            var resultado = _funcionarioAppService.Add(model);
            return Ok(resultado);
        }

        [HttpPut]
        public ActionResult Put(Guid id, [FromBody] FuncionarioViewModel model)
        {
            var resultado = _funcionarioAppService.Update(model);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _funcionarioAppService.Delete(id);
            return Ok();
        }
    }
}
