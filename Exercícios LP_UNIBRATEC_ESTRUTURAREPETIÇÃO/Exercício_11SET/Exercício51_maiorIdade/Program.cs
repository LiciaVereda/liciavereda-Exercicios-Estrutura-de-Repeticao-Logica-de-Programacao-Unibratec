using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício51_maiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, maiorIdade = 0, menorIdade = 0, contador=1;

            while(contador<=10)
            {   try
                {
                    Console.Write("Digite a {0}° idade: ", contador);
                    idade = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Idade Inválida. Digite valores numéricos");
                    continue;
                }


                if( idade<0 || idade > 120)
                {
                    Console.WriteLine("Idade Imválida. Digite idades positivas e menores que 120");
                    continue;
                }

                if(contador == 1)
                {
                    menorIdade = idade;
                    maiorIdade = idade;
                }

                if (idade < menorIdade)
                {
                    menorIdade = idade;
                }
                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                contador++;
            }
            Console.WriteLine("");
            Console.WriteLine("{0} anos é a menor idade", menorIdade);
            Console.WriteLine("{0} anos é a maior idade", maiorIdade);
            Console.ReadKey();

            
        }
    }
}
