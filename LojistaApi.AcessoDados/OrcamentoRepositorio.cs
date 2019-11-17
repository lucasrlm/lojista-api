using LojistaApi.AcessoDados.Interface;
using LojistaApi.Model;
using LojistaApi.Model.Orcamento;

namespace LojistaApi.AcessoDados
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        public RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return new RetornoBase()
            {
                Id = 1
            };
        }

        public void AlterarOrcamento(int orcamentoId, OrcamentoRequisicao orcamentoRequisicao)
        {
            return;
        }
    }
}
