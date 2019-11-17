using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model.Orcamento;

namespace LojistaApi.AcessoDados
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        public int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return 1;
        }

        public void AlterarOrcamento(int orcamentoId, OrcamentoRequisicao orcamentoRequisicao)
        {
            return;
        }
    }
}
