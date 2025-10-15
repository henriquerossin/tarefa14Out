using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa03
{
    public abstract class Veiculo
    {

        private string marca;
        private string modelo;
        private string ano;

        public Veiculo()
        {
        }

        public Veiculo(string marca, string modelo, string ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public virtual void ExibirInformacao()
        {

        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string GetModelo()
        {
            return this.modelo;
        }

        public void SetAno(string ano)
        {
            this.ano = ano;
        }

        public string GetAno()
        {
            return this.ano;
        }
    }
}
