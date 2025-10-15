namespace Tarefa02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o titular da conta: ");
            string Titular = Console.ReadLine()!;

            Console.Write("Informe o saldo inicial depositado: ");
            double SaldoInicial = double.Parse(Console.ReadLine()!);

            ContaBancaria conta = new ContaBancaria(SaldoInicial, Titular);

            Console.WriteLine();

            ContaBancaria Operacoes(ContaBancaria conta)
            {
                int opcao = 0;
                while (opcao != 3)
                {
                    Console.WriteLine("Informe o tipo de operação: ");
                    Console.WriteLine("1 - Saque");
                    Console.WriteLine("2 - Depósito");
                    Console.WriteLine("3 - Sair");
                    opcao = int.Parse(Console.ReadLine()!);

                    switch (opcao)
                    {
                        case 1:
                            conta.Saque();
                            break;
                        case 2:
                            conta.Depositar();
                            break;
                        case 3:
                            Console.WriteLine("Saindo.");
                            break;
                    }

                }

                return conta;
            }

            Operacoes(conta);

            Console.WriteLine($"Estado final: {conta.GetTitular()}, saldo ${conta.GetSaldo()}");
        }
    }
}
