using LojistaApi.Model.Solicitacao;
using LojistaApi.Negocio.Interfaces;
using LojistaApi.Util;
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
            var retorno = _solicitacaoNegocio.CriarSolicitacao(solicitacao);
            return Ok(retorno);
        }

        [HttpPut("{solicitacaoId}")]
        public ActionResult Put(int solicitacaoId, [FromBody]SolicitacaoStatus solicitacao)
        {
            _solicitacaoNegocio.AlterarSolicitacao(solicitacaoId, solicitacao);
            return Ok();
        }
    }
}
