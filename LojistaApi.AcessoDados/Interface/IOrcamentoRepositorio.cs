using LojistaApi.Model;
using LojistaApi.Model.Orcamento;

namespace LojistaApi.AcessoDados.Interface
{
    public interface IOrcamentoRepositorio
    {
        RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);

        void AlterarOrcamento(int orcamentoId, OrcamentoRequisicao orcamentoRequisicao);
    }
}
