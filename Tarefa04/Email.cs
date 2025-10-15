using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa04
{
    public class Email : Notificacao
    {
        public Email()
        {
        }
        public override void Enviar(string mensagem)
        {
            base.Enviar(mensagem);
            Console.WriteLine("Enviado por Email");
        }
    }
}
