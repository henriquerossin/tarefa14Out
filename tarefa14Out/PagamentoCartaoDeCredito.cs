using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tarefa14Out;

namespace tarefa14Out
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public PagamentoCartaoDeCredito(double valor, DateTime dataDePagamento) : base(valor, dataDePagamento)
        {

        }

        public override void ProcessarPagamento()
        {
            double juros = 0;
            base.ProcessarPagamento();

            if (GetDataDePagamento() < DateTime.Now)
            {
                juros = 0.1;
            }
            double ValorFinal = (GetValor()) * (1 + juros);

            Console.WriteLine($"Pagamento final com cartão de crédito: {ValorFinal:F2}");
        }
    }
}
