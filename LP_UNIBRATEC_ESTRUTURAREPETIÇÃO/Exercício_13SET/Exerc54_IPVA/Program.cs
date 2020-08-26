using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc54_IPVA
{
    class Program
    {
        static void Main(string[] args)
        {
            const double percentualIPVA = 0.10;
            string placa, partePlaca;
            double valorVeiculo, valorArrecadadoIpvaTotal, valorArrecadadoIpvaJaneiro=0, valorArrecadadoIpvaFevereiro=0, valorArrecadadoIpvaMarco=0, valorArrecadadoIpvaAbril=0;
            int contador=0;

            while (contador < 2)
            {
                Console.WriteLine("");
                Console.Write("Digite a placa do carro");
                placa = Console.ReadLine();
                partePlaca = placa.Substring(3,1);
               
                Console.Write("Digite o valor do veículo: R$ ");
                valorVeiculo = Convert.ToDouble(Console.ReadLine());


                if (partePlaca == "1" || partePlaca == "2" || partePlaca == "3")
                {
                    Console.WriteLine("");
                    Console.Write("O mês para pagamento do IPVA é janeiro ");
                    valorArrecadadoIpvaJaneiro += percentualIPVA * valorVeiculo;
                }
                else if (partePlaca == "4" || partePlaca == "5" || partePlaca == "6")
                {
                    Console.WriteLine("");
                    Console.Write("O mês para pagamento do IPVA é FEVEREIRO ");
                    valorArrecadadoIpvaFevereiro += percentualIPVA * valorVeiculo;
                }
                else if (partePlaca == "7" || partePlaca == "8" || partePlaca == "9")
                {
                    Console.WriteLine("");
                    Console.Write("O mês para pagamento do IPVA é MARÇO ");
                    valorArrecadadoIpvaMarco += percentualIPVA * valorVeiculo;
                }

                else if (partePlaca == "0")
                {
                    Console.WriteLine("");
                    Console.Write("O mês para pagamento do IPVA é ABRIL ");
                    valorArrecadadoIpvaAbril += percentualIPVA * valorVeiculo;
                }
                contador++;                           

            }
            valorArrecadadoIpvaTotal = valorArrecadadoIpvaJaneiro + valorArrecadadoIpvaFevereiro + valorArrecadadoIpvaMarco + valorArrecadadoIpvaAbril;

            Console.WriteLine("O valor arrecadado com o IPVA no mês de JANEIRO é: R$ {0,6:F2}", valorArrecadadoIpvaJaneiro);
            Console.WriteLine("O valor arrecadado com o IPVA no mês de FEVEREIRO é: R$ {0,6:F2}", valorArrecadadoIpvaFevereiro);
            Console.WriteLine("O valor arrecadado com o IPVA no mês de MARÇO é: R$ {0,6:F2}", valorArrecadadoIpvaMarco);
            Console.WriteLine("O valor arrecadado com o IPVA no mês de ABRIL é: R$ {0,6:F2}", valorArrecadadoIpvaAbril);
            Console.WriteLine("O valor total arrecadado com o IPVA é: R$ {0,6:F2}", valorArrecadadoIpvaTotal);
            Console.ReadKey();


        }
    }
}
