using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1 = new Mensagem();
            msg1.setTextoMensagem("Hello World!");
            //msg1.ExibirMensagem();
            Console.WriteLine(msg1.getTextoMensagem());
        }
    }
}