using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício53_Matricula
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, parteNome="", nomeResponsavel;
            int idade, contadorRejeitado=0, contador=0;
            double percentualMatriculaRejeitada = 0;

            while (parteNome != "XX")
            {
                Console.WriteLine("");
                Console.Write("Digite o nome do aluno: ");
                nome = Console.ReadLine();
                nome = nome.ToUpper();
                parteNome = nome.Substring(0, 2);

                if (parteNome == "XX")
                {
                    break;
                }

                else
                {
                    Console.Write("Digite a idade do possível aluno: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    
                    if (idade < 15)
                    {
                        Console.Write("Aluno NÃO PODE SER MATRICULADO");
                        Console.WriteLine("");
                        contadorRejeitado++;
                    }


                    else if (idade >= 15 && idade < 21)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Aluno SÓ PODE SE MATRICULAR COM O RESPONSÁVEL");
                        Console.WriteLine("Digite o nome do responsável pelo aluno: ");
                        nomeResponsavel = Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("O ALUNO PODE SE MATRICULAR");
                    }
                    contador++;

                }
            }
            percentualMatriculaRejeitada = (double)contadorRejeitado  / contador ;

            Console.WriteLine("contadorRejeitado" +contadorRejeitado);
            Console.WriteLine("contadorTOTAL" +contador);

            Console.WriteLine("Percentual d ematriculas rejeitadas {0,6:P}",percentualMatriculaRejeitada);
           
            Console.ReadKey();
        }
    }
}
