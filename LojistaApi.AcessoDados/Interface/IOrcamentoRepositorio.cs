using LojistaApi.Model.Orcamento;

namespace LojistaApi.AcessoDados.Interface
{
    public interface IOrcamentoRepositorio
    {
        int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);

        void AlterarOrcamento(int orcamentoId, OrcamentoRequisicao orcamentoRequisicao);
    }
}
