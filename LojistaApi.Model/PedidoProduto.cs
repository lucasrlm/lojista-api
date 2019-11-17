using LojistaApi.Util.Excecao;
using System;

namespace LojistaApi.Model
{
    public class PedidoProduto
    {
        public int ProdutoId { get; set; }

        public int QuantidadeItens { get; set; }

        public string Observacoes { get; set; }
    }
}
