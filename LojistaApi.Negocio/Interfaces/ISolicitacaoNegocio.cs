using LojistaApi.Model.Solicitacao;

namespace LojistaApi.Negocio.Interfaces
{
    public interface ISolicitacaoNegocio
    {
        int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
