using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício49_MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, qtdeMaiorIdade=0, contador = 1;

            while (contador <= 10)
            {
                Console.Write("Digite a idade {0} ", contador);
                idade = Convert.ToInt32(Console.ReadLine());

                if(idade > 18)
                {
                    qtdeMaiorIdade+= 1;

                }
                contador++;
            }

            Console.WriteLine("A qauntidade de pessoas maior de idade é: {0}", qtdeMaiorIdade);
            Console.ReadKey();

        }
    }
}
