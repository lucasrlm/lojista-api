using System;

namespace LojistaApi.Model.Orcamento
{
    public class Orcamento
    {
        public int AtacadistaId { get; set; }

        public int LojistaId { get; set; }

        public int SolicitacaoId { get; set; }

        public decimal Custo { get; set; }

        public DateTime DataEntrega { get; set; }
    }
}
