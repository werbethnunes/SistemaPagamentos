using System;
using SistemaPagamentos.Menus;
using SistemaPagamentos.Models;

namespace SistemaPagamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Menu.ExibirMenu();
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        ProcessarCartao();
                        break;

                    case 2:
                        ProcessarBoleto();
                        break;

                    case 3:
                        Console.WriteLine("Saindo do sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opcao != 3);
        }

        static void ProcessarCartao()
        {
            Console.Write("Informe o valor do pagamento: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o número do cartão: ");
            string numeroCartao = Console.ReadLine();

            PagamentoCartao pagamento = new PagamentoCartao();
            pagamento.Valor = valor;
            pagamento.NumeroCartao = numeroCartao;
            pagamento.DataPagamento = DateTime.Now;

            Console.WriteLine(pagamento.ProcessarPagamento());
        }

        static void ProcessarBoleto()
        {
            Console.Write("Informe o valor do pagamento: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.Write("Informe o código de barras: ");
            string codigoBarras = Console.ReadLine();

            PagamentoBoleto pagamento = new PagamentoBoleto();
            pagamento.Valor = valor;
            pagamento.CodigoBarras = codigoBarras;
            pagamento.DataPagamento = DateTime.Now;

            Console.WriteLine(pagamento.ProcessarPagamento());
        }
    }
}