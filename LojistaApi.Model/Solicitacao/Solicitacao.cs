using LojistaApi.Util;
using System.Collections.Generic;

namespace LojistaApi.Model.Solicitacao
{
    public class Solicitacao
    {
        public int LojistaId { get; set; }

        public int AtacadistaId { get; set; }

        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
