using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataComMesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data="";
            int dia = 0, mes = 0, ano = 0;



            while (true)
            {
                Console.WriteLine("");
                Console.Write("Digite uma data no formato DD/MM/AAAA ");
                data = Console.ReadLine();


                if (data.Length != 10)
                {
                    Console.WriteLine("Data inválida. Digite no formato correto");
                    continue;
                }
                try
                {
                    dia = Convert.ToInt32(data.Substring(0, 2));
                    mes = Convert.ToInt32(data.Substring(3, 2));
                    ano = Convert.ToInt32(data.Substring(6, 4));
                }

                catch
                {
                    Console.WriteLine("Data Inválida. Digite apenas valores numéricos");
                    continue;
                }


                if (dia<0 || dia>31)
                {
                    Console.WriteLine("Dia inválido. Digite no formato");
                    continue;
                }

                if (mes < 0 || mes > 12)
                {
                    Console.WriteLine("Mês inválido. Digite no formato");
                    continue;
                }

                if((data.Substring(2,1)!="/") && (data.Substring(5, 1)!="/"))
                {
                    Console.WriteLine("Digite o separador correto. Digite / ");
                    continue;
                }

                if (ano < 0 )
                {
                    Console.WriteLine("Ano inválido. Digite no formato");
                    continue;
                }


                if (mes == 01) 
                {
                    Console.WriteLine("A data é {0} de janeiro de {1}", dia, ano);

                }

                else if (mes == 02)
                {
                    Console.WriteLine("A data é {0} de fevereiro de {1}", dia, ano);

                }

                else if (mes == 03)
                {
                    Console.WriteLine("A data é {0} de março de {1}", dia, ano);

                }

                else if (mes == 04)
                {
                    Console.WriteLine("A data é{0} de abril de {1}", dia, ano);

                }

                else if (mes == 05)
                {
                    Console.WriteLine("A data é {0} de maio de {1}", dia, ano);

                }

                else if (mes == 06)
                {
                    Console.WriteLine("A data é {0} de junho de {1}", dia, ano);

                }

                else if (mes == 07)
                {
                    Console.WriteLine("A data é {0} de julho de {1}", dia, ano);

                }

                else if (mes == 08)
                {
                    Console.WriteLine("A data é {0} de agosto de {1}", dia, ano);

                }
                else if (mes == 09)
                {
                    Console.WriteLine("A data é {0} de setembro de {1}", dia, ano);

                }

                else if (mes == 10)
                {
                    Console.WriteLine("A data é {0} de outubro de {1}", dia, ano);

                }

                else if (mes == 11)
                {
                    Console.WriteLine("A data é {0} de novembro de {1}", dia, ano);

                }

                else if (mes == 12)
                {
                    Console.WriteLine("A data é {0} de dezembro de {1}", dia, ano);

                }
                Console.ReadKey();
                break;


            }
        }
    }
}
