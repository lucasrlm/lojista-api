using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Servicos.Interface;

namespace LojistaApi.AcessoDados
{
    public class SolicitacaoRepositorio : ISolicitacaoRepositorio
    {
        private IAtacadistaApi _atacadistaApi;

        public SolicitacaoRepositorio(IAtacadistaApi atacadistaApi)
        {
            _atacadistaApi = atacadistaApi;
        }

        public int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return _atacadistaApi.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            _atacadistaApi.AlterarSolicitacao(solicitacaoId, solicitacaoRequisicao);
        }
    }
}
