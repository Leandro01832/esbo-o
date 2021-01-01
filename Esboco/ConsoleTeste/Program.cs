using business.classes;
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
            Console.WriteLine(" Nossas fontes: ");
            int i = 1;
            foreach (var fonte in m.Fonte)
            {
                Fonte f = (Fonte) new Fonte(fonte.Id, true).recuperar(fonte.Id)[0];
                Console.WriteLine("Fonte: " + i);
                Console.WriteLine("Livro: " + f.Livro);
                Console.WriteLine("Autor: " + f.Autor);
                Console.WriteLine(" Versiculos da fonte: ");
                foreach (var v in f.Versiculo)
                {
                    Console.WriteLine($"Versiculo do capitulo{v.Capitulo} da Fonte {i}: ");
                    Console.WriteLine(v.Texto);
                    Console.WriteLine(" -------------------------------||------------------------------- ");
                    Console.WriteLine(" -------------------------------||------------------------------- ");
                }
                i++;
                Console.WriteLine("-------------------------------------------||------------------------------------------- ");
                Console.WriteLine("-------------------------------------------||------------------------------------------- ");
                Console.WriteLine("-------------------------------------------||------------------------------------------- ");
            }

            Console.ReadKey(true);



        }
    }
}
