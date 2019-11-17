using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Orcamento;
using LojistaApi.Negocio.Interfaces;

namespace LojistaApi.Negocio
{
    public class OrcamentoNegocio : IOrcamentoNegocio
    {
        private readonly IOrcamentoRepositorio _orcamentoRepositorio;

        public OrcamentoNegocio(IOrcamentoRepositorio orcamentoRepositorio)
        {
            _orcamentoRepositorio = orcamentoRepositorio;
        }

        public int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return _orcamentoRepositorio.CriarOrcamento(orcamentoRequisicao);
        }
    }
}
