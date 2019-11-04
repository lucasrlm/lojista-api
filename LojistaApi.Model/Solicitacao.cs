using LojistaApi.Util;
using System.Collections.Generic;

namespace LojistaApi.Model
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }

        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
