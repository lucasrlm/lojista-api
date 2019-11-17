using LojistaApi.Model.Orcamento;
using LojistaApi.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojistaApi.Controllers
{
    [Route("api/orcamento")]
    [ApiController]
    public class OrcamentoController : ControllerBase
    {
        private readonly IOrcamentoNegocio _orcamentoNegocio;

        public OrcamentoController(IOrcamentoNegocio orcamentoNegocio)
        {
            _orcamentoNegocio = orcamentoNegocio;
        }

        [HttpPost]
        public ActionResult Post([FromBody]OrcamentoRequisicao orcamento)
        {
            var orcamentoId = _orcamentoNegocio.CriarOrcamento(orcamento);
            return Ok(orcamentoId);
        }
    }
}
