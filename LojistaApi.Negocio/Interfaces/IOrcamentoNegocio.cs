using LojistaApi.Model;
using LojistaApi.Model.Orcamento;

namespace LojistaApi.Negocio.Interfaces
{
    public interface IOrcamentoNegocio
    {
        RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
