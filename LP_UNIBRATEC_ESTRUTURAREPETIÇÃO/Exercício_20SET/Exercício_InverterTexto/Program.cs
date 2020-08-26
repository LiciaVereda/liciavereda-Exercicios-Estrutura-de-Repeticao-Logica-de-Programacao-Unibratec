using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_InverterTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "", texto2 = "", novaPalavra="", novaPalavra1 = "";
            int tamanhoTexto1 = 0, tamanhotexto2 = 0;

            while (true)
            {
                Console.Write("Digite a palavra 1: ");
                texto1 = Console.ReadLine();
                texto1 = texto1.ToUpper();
                Console.Write("Digite palavra 2 do mesmo tamanho da palavra 1: ");
                texto2 = Console.ReadLine();
                texto2 = texto2.ToUpper();

                if(texto1.Length != texto2.Length)
                {
                    Console.WriteLine("Digite palavras do mesmo tamanho");
                    continue;
                }

                break;
            }

            for (int i = 0; i < texto1.Length; i++)
            {
              
                    novaPalavra = texto1.Substring(i, 1) + texto2.Substring(i, 1);
                    novaPalavra1 += novaPalavra;
                  
                              
            }

            Console.WriteLine("A nova palavra é:{0}", novaPalavra1);
            Console.ReadKey();


        }
    }
}
