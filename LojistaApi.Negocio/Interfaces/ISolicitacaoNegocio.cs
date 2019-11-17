using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;

namespace LojistaApi.Negocio.Interfaces
{
    public interface ISolicitacaoNegocio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
