using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa04
{
    internal class SMS : Notificacao
    {
        public SMS()
        {
        }
        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine("Enviado por SMS");
        }
    }
}
