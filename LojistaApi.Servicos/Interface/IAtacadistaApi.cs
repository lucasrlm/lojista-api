using LojistaApi.Model.Solicitacao;

namespace LojistaApi.Servicos.Interface
{
    public interface IAtacadistaApi
    {
        int CriarSolicitacao(Solicitacao solicitacao);

        void AlterarSolicitacao(int solicitacaoId, Solicitacao solicitacao);
    }
}
