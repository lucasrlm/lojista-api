using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;

namespace LojistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
