using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa02
{
    public class ContaBancaria
    {

        private double saldo;

        private string titular;

        public ContaBancaria()
        {
        }

        public ContaBancaria(double saldo, string titular)
        {
            this.saldo = saldo;
            this.titular = titular;
        }

        public void Depositar()
        {
            Console.Write("Informe o valor a ser depositado: ");
            double deposito = double.Parse(Console.ReadLine()!);
            this.saldo += deposito;
        }

        public void Saque()
        {
            Console.Write("Informe o valor a ser sacado: ");
            double saque = double.Parse(Console.ReadLine()!);
            if (saque > GetSaldo())
            {
                Console.WriteLine($"Operação negada, tentativa de saque maior que saldo total ({GetSaldo()}).");
            }
            else
            {
                this.saldo -= saque;
                Console.WriteLine($"Saque realizado com sucesso! Saldo total {GetSaldo()}");
            }
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public string GetTitular()
        {
            return titular;
        }

    }
}
