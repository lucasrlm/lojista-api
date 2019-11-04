using LojistaApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LojistaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitacaoController : ControllerBase
    {
        [HttpPost]
        public ActionResult Post([FromBody]Solicitacao solicitacao)
        {

            return Ok(solicitacao);
        }

        [HttpPut("{solicitacaoId}")]
        public ActionResult Put(int solicitacaoId, [FromBody]Solicitacao solicitacao)
        {
            return Ok(solicitacao);
        }
    }
}
