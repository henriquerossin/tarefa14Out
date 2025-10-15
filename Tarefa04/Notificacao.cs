using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa04
{
    public abstract class Notificacao
    {
        public Notificacao() {}
        public virtual void Enviar(string mensagem)
        {
            Console.WriteLine("Umas mensagem aí");
        }
    }
}
