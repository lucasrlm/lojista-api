using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Util;

namespace LojistaApi.Servicos.Interface
{
    public interface IAtacadistaApi
    {
        RetornoBase CriarSolicitacao(Solicitacao solicitacao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus);
    }
}
