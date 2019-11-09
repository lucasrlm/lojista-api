using LojistaApi.Model.Solicitacao;

namespace LojistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
