using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Negocio.Interfaces;

namespace LojistaApi.Negocio
{
    public class SolicitacaoNegocio : ISolicitacaoNegocio
    {
        private readonly ISolicitacaoRepositorio _atacadistaRepositorio;

        public SolicitacaoNegocio(ISolicitacaoRepositorio atacadistaRepositorio)
        {
            _atacadistaRepositorio = atacadistaRepositorio;
        }

        public int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            // var solicitacaoId = _solicitacaoRepositorio.CriarSolicitacao(solicitacaoRequisicao);
            return _atacadistaRepositorio.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            _atacadistaRepositorio.AlterarSolicitacao(solicitacaoId, solicitacaoRequisicao);
        }
    }
}
