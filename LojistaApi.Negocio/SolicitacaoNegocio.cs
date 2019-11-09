using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Negocio.Interfaces;

namespace LojistaApi.Negocio
{
    public class SolicitacaoNegocio : ISolicitacaoNegocio
    {
        private readonly ISolicitacaoRepositorio _solicitacaoRepositorio;

        public SolicitacaoNegocio(ISolicitacaoRepositorio solicitacaoRepositorio)
        {
            _solicitacaoRepositorio = solicitacaoRepositorio;
        }

        public int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return _solicitacaoRepositorio.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            _solicitacaoRepositorio.AlterarSolicitacao(solicitacaoId, solicitacaoRequisicao);
        }
    }
}
