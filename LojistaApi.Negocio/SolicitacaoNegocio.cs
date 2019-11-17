using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Negocio.Interfaces;

namespace LojistaApi.Negocio
{
    public class SolicitacaoNegocio : ISolicitacaoNegocio
    {
        private readonly ISolicitacaoRepositorio _solicitacaoRepositorio;

        public SolicitacaoNegocio(ISolicitacaoRepositorio atacadistaRepositorio)
        {
            _solicitacaoRepositorio = atacadistaRepositorio;
        }

        public RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            // var solicitacaoId = _solicitacaoRepositorio.CriarSolicitacao(solicitacaoRequisicao);
            return _solicitacaoRepositorio.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            _solicitacaoRepositorio.AlterarSolicitacao(solicitacaoId, solicitacaoRequisicao);
        }
    }
}
