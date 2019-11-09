using LojistaApi.Util.Excecao;
using System;

namespace LojistaApi.Model
{
    public class PedidoProduto
    {
        public int ProdutoId { 
            get { return ProdutoId; } 
            set {
                if (ProdutoId <= 0)
                    throw new BadRequestException("Identificador de produto inválido.");
            } 
        }

        public int QuantidadeItens
        {
            get { return QuantidadeItens; }
            set
            {
                if (QuantidadeItens <= 0)
                    throw new BadRequestException("Quantidade de itens inválida.");
            }
        }

        public string Observacoes { get; set; }
    }
}
