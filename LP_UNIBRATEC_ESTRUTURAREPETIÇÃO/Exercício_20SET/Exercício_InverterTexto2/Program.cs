using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_InverterTexto2
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "", novaPalavra = "";
            int tamanhoPalavra = 0;

            Console.Write("Digite a palavra: ");
            palavra = Console.ReadLine();
            tamanhoPalavra = palavra.Length;
   
            for (int i = tamanhoPalavra -1; i >= 0; i--)
            {
                novaPalavra += palavra.Substring(i, 1);
            }

            Console.WriteLine("Texto invertido:{0}",novaPalavra);
            Console.ReadKey();

        }
    }
}
