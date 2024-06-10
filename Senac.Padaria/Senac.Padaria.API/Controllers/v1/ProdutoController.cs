using Microsoft.AspNetCore.Mvc;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;

namespace Senac.Padaria.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var resultado = _produtoAppService.Buscar(p => true);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoViewModel> Get(Guid id)
        {
            var resultado = _produtoAppService.GetById(id);
            return Ok(resultado);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoViewModel model)
        {
            var resultado = _produtoAppService.Add(model);
            return Ok(resultado);
        }

        [HttpPut]
        public ActionResult Put(Guid id, [FromBody] ProdutoViewModel model)
        {
            var resultado = _produtoAppService.Update(model);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _produtoAppService.Delete(id);
            return Ok();
        }
    }
}
