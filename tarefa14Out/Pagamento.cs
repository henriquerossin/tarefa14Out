using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa14Out
{
    public abstract class Pagamento
    {

        private double Valor { get; set; }

        private DateTime DataDePagamento { get; set; }

        public Pagamento(double valor, DateTime dataDePagamento)
        {
            Valor = valor;
            DataDePagamento = dataDePagamento;
        }
        public virtual void ProcessarPagamento()
        {
        }

        public void SetValor(double valor)
        {
            this.Valor = valor;
        }

        public double GetValor()
        {
            return Valor;
        }

        public void SetDataDePagamento(DateTime dataDePagamento)
        {
            this.DataDePagamento = dataDePagamento;
        }

        public DateTime GetDataDePagamento()
        {
            return this.DataDePagamento;
        }
    }
}
