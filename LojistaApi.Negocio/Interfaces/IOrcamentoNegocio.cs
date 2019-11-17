using LojistaApi.Model.Orcamento;

namespace LojistaApi.Negocio.Interfaces
{
    public interface IOrcamentoNegocio
    {
        int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
