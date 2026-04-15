using System;

namespace SistemaPagamentos.Models
{
    public class PagamentoBoleto
    {
        public decimal Valor { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime DataPagamento { get; set; }

        public string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor} via Boleto (Cod Barra: {CodigoBarras}) na data {DataPagamento:dd/MM/yyyy}.";
        }
    }
}