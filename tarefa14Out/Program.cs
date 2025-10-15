namespace tarefa14Out
{
    public class Program
    {
        public static void Main(string[] args)
        {

            PagamentoCartaoDeCredito PegarDadosCredito()
            {
                Console.WriteLine("Digite o valor: ");
                double valor = double.Parse(Console.ReadLine()!);

                Console.Write("Digite a data de pagamento (dd/MM/yyyy): ");
                DateTime data = DateTime.Parse(Console.ReadLine()!);

                PagamentoCartaoDeCredito cartao = new PagamentoCartaoDeCredito(valor, data);
                cartao.ProcessarPagamento();

                return cartao;
            }

            PagamentoBoleto PegarDadosBoleto()
            {
                Console.Write("Digite o valor: ");
                double valor = double.Parse(Console.ReadLine()!);

                Console.Write("Digite a data de pagamento (dd/MM/yyyy): ");
                DateTime data = DateTime.Parse(Console.ReadLine()!);

                PagamentoBoleto boleto = new PagamentoBoleto(valor, data);
                boleto.ProcessarPagamento();

                return boleto;
            }


            void ExecutarOperacao()
            {
                int opcao = 0;
                do
                {
                    Console.WriteLine("Informe o tipo de operação: ");
                    Console.WriteLine("1 - Pagamento com cartão de crédito");
                    Console.WriteLine("2 - Pagamento com boleto: ");
                    Console.WriteLine("3 - Sair.");
                    opcao = int.Parse(Console.ReadLine()!);

                    switch (opcao)
                    {
                        case 1:
                            PegarDadosCredito();
                            break;
                        case 2:
                            PegarDadosBoleto();
                            break;
                        case 3:
                            Console.WriteLine("Saindo...");
                            break;
                        default:
                            Console.WriteLine("Selecione uma opção válida");
                            break;
                    }

                } while (opcao != 3);
            }

            ExecutarOperacao();
        }
    }
}
