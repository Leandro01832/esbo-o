using business.classes;
using business.classes.Abstrato;
using business.classes.Fontes;
using business.database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem m = (Mensagem)new Mensagem(1, true).recuperar(1)[0];

            Console.WriteLine("Esta é a nossa mensagem: " + m.Tipo);
            Console.WriteLine(" -------------------------------||------------------------------- ");
            Console.WriteLine(" --Fontes da mensagem-- ");
            Console.WriteLine(" --Versiculos-- ");
            foreach (var fonte in m.Fonte.OfType<Versiculo>())
            {
                Console.WriteLine("Livro: " + fonte.Livro);
                Console.WriteLine("Capitulo: " + fonte.Capitulo);
                Console.WriteLine("Texto: " + fonte.Texto);                
            }

            Console.ReadKey(true);



        }
    }
}
