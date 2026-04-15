using System;

namespace SistemaPagamentos.Models
{
    public class PagamentoCartao
    {
        public decimal Valor { get; set; }
        public string NumeroCartao { get; set; }
        public DateTime DataPagamento { get; set; }

        public string ProcessarPagamento()
        {
            return $"Processando pagamento de R$ {Valor} via Cartão (Número: {NumeroCartao}) na data {DataPagamento:dd/MM/yyyy}.";
        }
    }
}