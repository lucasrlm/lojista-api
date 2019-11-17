using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Servicos.Interface;
using LojistaApi.Util;

namespace LojistaApi.AcessoDados
{
    public class SolicitacaoRepositorio : ISolicitacaoRepositorio
    {
        private IAtacadistaApi _atacadistaApi;

        public SolicitacaoRepositorio(IAtacadistaApi atacadistaApi)
        {
            _atacadistaApi = atacadistaApi;
        }

        public RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return _atacadistaApi.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus)
        {
            _atacadistaApi.AlterarSolicitacao(solicitacaoId, solicitacaoStatus);
        }
    }
}
