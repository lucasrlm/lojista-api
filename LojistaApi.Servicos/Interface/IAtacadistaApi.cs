using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;

namespace LojistaApi.Servicos.Interface
{
    public interface IAtacadistaApi
    {
        RetornoBase CriarSolicitacao(Solicitacao solicitacao);

        void AlterarSolicitacao(int solicitacaoId, Solicitacao solicitacao);
    }
}
