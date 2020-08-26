using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício52_NomeMenorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, maiorIdade = 0, contador = 1;
            string nome= "";

            while (contador <= 10)
            {
                try
                {
                    Console.WriteLine("");
                    Console.Write("Digite o nome da {0}° pessoa: ", contador);
                    nome = Console.ReadLine();
                    
                    Console.Write("Digite a {0}° idade: ", contador);
                    idade = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Idade Inválida. Digite valores numéricos");
                    continue;
                }


                if (idade < 0 || idade > 120)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Idade Inválida. Digite idades positivas e menores que 120");
                    continue;
                }

                if (contador == 1)
                {
                    maiorIdade = idade;
                    nome = nome;
                }

               
                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                    nome = nome;
                }
                contador++;
            }
            Console.WriteLine("");
            Console.WriteLine("{0} anos é a maior idade", maiorIdade);
            Console.WriteLine("{0} é o nome da pessoa com a maior idade", nome);
            Console.ReadKey();


        }
    }

}
    

