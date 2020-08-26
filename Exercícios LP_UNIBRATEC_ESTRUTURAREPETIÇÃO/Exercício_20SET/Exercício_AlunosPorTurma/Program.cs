using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_AlunosPorTurma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para receber informações de várias turmas.
            Cada informação deve ser digitada no seguinte formato CCCTNNN, onde:
            - CCC é a sigla do curso
            - T é o turno
            - NNN é a quantidade de alunos do curso informado

             Deverá haver crítica para as seguintes situações:
            - Tamanho do dado aceito para processamento deve ter 7 posições
            - As siglas dos cursos são compostas apenas de letras.
            - Os turnos aceitos são M ou T.
            - A quantidade de alunos só poderá representar valores de 0 a 999

            A entrada de dados encerra quando for digitado “FIM” como sigla do curso.
            No final o programa deverá exibir:
            - O nome do curso com maior quantidade de alunos (considerar que não houve empate).
            - A quantidade de alunos por turno */

            string codigoTurma = "", nomeCursoMaior="";
            
            int qtdeAlunos, maiorTurma=0, qtdeTurnoM=0, qtdeTurnoT = 0;


            while (true)
            
            {
                Console.WriteLine("");
                Console.Write("Digite a sigla do curso, o turno e a quantidade de alunos no seguinte formato CCCTNNN ");
                codigoTurma = Console.ReadLine();
                codigoTurma = codigoTurma.ToUpper();

                if((codigoTurma.Substring(0, 3) == "FIM"))
                {
                    break;
                }

                if (codigoTurma.Length != 7)
                {
                    Console.WriteLine("Informação inválida.Digite os dados no formato correto");
                    continue;

                }

                if((codigoTurma.Substring(3, 1)!= "M") && (codigoTurma.Substring(3, 1)!="T"))
              
                {
                    Console.WriteLine("Turno errado. Digite M ou T");
                    Console.WriteLine(codigoTurma.Substring(3, 1));
                    continue;
                }

                try
                {
                    qtdeAlunos = Convert.ToInt32(codigoTurma.Substring(4, 3));
                }

                catch
                {
                    Console.WriteLine("Digite apenas valores númericos.");
                    continue;
                }

                if (qtdeAlunos > 999)
                {
                    Console.WriteLine("Qunatidade de alunos inválida. Digite valores entre 0 e 999");
                }

                if(maiorTurma < qtdeAlunos)
                {
                    maiorTurma = qtdeAlunos;
                    nomeCursoMaior = codigoTurma.Substring(0, 3);
                }

                if (codigoTurma.Substring(3, 1) == "M")
                {
                    qtdeTurnoM += qtdeAlunos;
                }

                else if (codigoTurma.Substring(3, 1) == "T")
                {
                    qtdeTurnoT += qtdeAlunos;
                }

               

            }
            Console.WriteLine("A turma com mais alunos é do curso de: {0}", nomeCursoMaior);
            Console.WriteLine("O número de alunos no turno da manhã é de: {0}", qtdeTurnoM);
            Console.WriteLine("O número de alunos no turno da tarde é de: {0}", qtdeTurnoT);
            Console.ReadKey();
        }
    }
}
