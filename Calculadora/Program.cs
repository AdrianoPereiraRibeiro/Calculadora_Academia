using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
          bool deveFicar = true;

            while (deveFicar = true)
            {

                string operação = Exibirmenu();

                if (OperaçãoInvalida(operação))
                {
                    
                   Console.WriteLine("Operação Inválida.");
                    Console.ReadLine();
                    continue;
                }

                if (operação == "6")
                    break;
                


                decimal n1int = ObterPrimeiroNumero();
                decimal n2int = ObterSegundoNumero();
                decimal resultado = 0;
                resultado = ProcessamentoParaTeroResultado(operação, n1int, n2int, resultado);
                MostrarResultado(resultado);

            }
        }

        static bool OperaçãoInvalida(string operação)
        {
            bool OperaçãoInvalida =operação != "1" && operação != "2" && operação != "3" && operação != "4" && operação != "5" && operação!="6";
            return OperaçãoInvalida;
        }

        static void MostrarResultado(decimal resultado)
        {
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadLine();
        }

         static decimal ObterSegundoNumero()
        {
            Console.WriteLine("Digite o segundo número número:");
            decimal n2int = Convert.ToDecimal(Console.ReadLine());
            return n2int;
        }

        static decimal ProcessamentoParaTeroResultado(string operação, decimal n1int, decimal n2int, decimal resultado)
        {
            if (operação == "1")

            {
                resultado = n1int + n2int;

            }

            else if (operação == "2")
            {
                resultado = n1int - n2int;

            }

            else if ((operação == "3" && n2int == 0))
            {
                Console.WriteLine("Impossível dividir por zero.");
                Console.ReadLine();
                
            }
            else if (operação == "3")
            {

                resultado = n1int / n2int;




            }

            else if (operação == "4")
            {
                resultado = n1int * n2int;
            }
            else if (operação == "5")
            {
                Console.WriteLine("Digite o valor do número:");
                decimal nt = Convert.ToDecimal(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    decimal tabuadares = i * nt;
                    Console.WriteLine(nt +
                    "x" + i + "=" + tabuadares);
                }
                
            }
          
            
            return resultado;
        }

        static decimal ObterPrimeiroNumero()
        {
            Console.WriteLine("Digite o primerio número:");
            decimal n1int = Convert.ToDecimal(Console.ReadLine());
            return n1int;
        }

   
        static string Exibirmenu()
        {
            Console.Clear();

            Console.WriteLine("Calculadora Tabajara 2024");

            Console.WriteLine("Digite 1 para adicionar:");
            Console.WriteLine("Digite 2 para Subtrair:");
            Console.WriteLine("Digite 3 para dividir:");
            Console.WriteLine("Digite 4 para multiplicar:");
            Console.WriteLine("Digite 5 para obter a tabuada de algum número:");
            Console.WriteLine("Digite 6  para sair:");

            string operação = Console.ReadLine();
            return operação;
        }
    }
}
