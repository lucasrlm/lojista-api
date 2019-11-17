using LojistaApi.Model.Solicitacao;
using LojistaApi.Negocio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojistaApi.Controllers
{
    [Route("api/solicitacao")]
    [ApiController]
    public class SolicitacaoController : ControllerBase
    {
        private readonly ISolicitacaoNegocio _solicitacaoNegocio;

        public SolicitacaoController(ISolicitacaoNegocio solicitacaoNegocio)
        {
            _solicitacaoNegocio = solicitacaoNegocio;
        }

        [HttpPost]
        public ActionResult Post([FromBody]SolicitacaoRequisicao solicitacao)
        {
            var solicitacaoId = _solicitacaoNegocio.CriarSolicitacao(solicitacao);
            return Ok(solicitacaoId);
        }

        [HttpPut("{solicitacaoId}")]
        public ActionResult Put(int solicitacaoId, [FromBody]SolicitacaoRequisicao solicitacao)
        {
            _solicitacaoNegocio.AlterarSolicitacao(solicitacaoId, solicitacao);
            return Ok();
        }
    }
}
