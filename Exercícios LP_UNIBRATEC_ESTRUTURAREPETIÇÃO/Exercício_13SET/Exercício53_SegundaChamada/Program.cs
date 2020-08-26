using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício53_SegundaChamada
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota , media, notaTotal = 0;
            int qtdeAlunos, contador=0;

            Console.Write("Digite quantos alunos farão a segunda chamada: ");
            qtdeAlunos = Convert.ToInt32(Console.ReadLine());


            if (qtdeAlunos == 0)
            {
                Console.WriteLine();

                Console.WriteLine("Não teve alunos para a realização da segunda chamada");
            }
            else
            {
                while (contador < qtdeAlunos)
                {
                    Console.Write("Digite a nota do aluno {0}º: ", contador);
                    nota = Convert.ToDouble(Console.ReadLine());

                    if (nota < 0)
                    {
                        Console.Write("Notas negativas são inválidas");
                        continue;
                    }

                    notaTotal += nota;
                    contador++;
                }
                media = notaTotal / qtdeAlunos;
                Console.WriteLine("A média geral das notas dos alunos foi de {0,6:F2}", media);
                Console.ReadKey();

            }

        
        


        }
    }
}
