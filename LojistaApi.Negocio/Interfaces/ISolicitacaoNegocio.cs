using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Util;

namespace LojistaApi.Negocio.Interfaces
{
    public interface ISolicitacaoNegocio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus);
    }
}
