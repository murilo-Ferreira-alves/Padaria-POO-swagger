using Microsoft.AspNetCore.Mvc;
using Senac.Padaria.Aplicantion.Interfaces;
using Senac.Padaria.Aplicantion.ViewModel;

namespace Senac.Padaria.API.Controllers.v1
{
    [ApiController]
    [Route("api/v1/venda")]
    public class VendaController : Controller
    {
        private readonly IVendaAppService _vendaAppService;

        public VendaController(IVendaAppService vendaAppService)
        {
            _vendaAppService = vendaAppService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var resultado = _vendaAppService.Buscar(p => true);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public ActionResult<VendaViewModel> Get(Guid id)
        {
            var resultado = _vendaAppService.GetById(id);
            return Ok(resultado);
        }

        [HttpPost]
        public ActionResult Post([FromBody] VendaViewModel model)
        {
            var resultado = _vendaAppService.Add(model);
            return Ok(resultado);
        }

        [HttpPut]
        public ActionResult Put(Guid id, [FromBody] VendaViewModel model)
        {
            var resultado = _vendaAppService.Update(model);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _vendaAppService.Delete(id);
            return Ok();
        }
    }
}
