using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Solicitacao;

namespace LojistaApi.AcessoDados
{
    public class SolicitacaoRepositorio : ISolicitacaoRepositorio
    {
        public int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return 1;
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return;
        }
    }
}
