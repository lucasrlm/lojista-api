using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Util;

namespace LojistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus);
    }
}
