using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa14Out
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(double valor, DateTime dataDePagamento) : base(valor, dataDePagamento)
        {

        }

        public override void ProcessarPagamento()
        {

            double juros = 0;
            base.ProcessarPagamento();

            if (GetDataDePagamento() < DateTime.Now)
            {
                juros = 0.3;
            }
            double ValorFinal = (GetValor()) * (1 + juros);

            Console.WriteLine($"Pagamento final em boleto: {ValorFinal:F2}");

        }
    }
}
