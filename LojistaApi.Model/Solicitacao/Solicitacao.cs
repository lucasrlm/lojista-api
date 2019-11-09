using LojistaApi.Util;
using System.Collections.Generic;

namespace LojistaApi.Model.Solicitacao
{
    public class Solicitacao
    {
        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
