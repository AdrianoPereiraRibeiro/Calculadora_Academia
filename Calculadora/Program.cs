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
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para adicionar:");
                Console.WriteLine("Digite 2 para Subtrair:");
                Console.WriteLine("Digite 3 para dividir:");
                Console.WriteLine("Digite 4 para multiplicar:");
                Console.WriteLine("Digite 5 para sair:");

                string operação = Console.ReadLine();                
                if (operação == "5")
                    break;              
               Console.WriteLine("Digite o primerio número:");
                           
                string n1str = Console.ReadLine();
                decimal n1int = Convert.ToDecimal(n1str);
                Console.WriteLine("Digite o segundo número número:");
               
                string n2str = Console.ReadLine();
                decimal n2int = Convert.ToDecimal(n2str);
                decimal resultado = 0;
                if (operação == "1")
                {
                    resultado = n1int + n2int;

                }

                else if (operação == "2")
                {
                    resultado = n1int - n2int;

                }

                else if ((operação == "3" && n2str == "0"))
                {
                    Console.WriteLine("Impossível dividir por zero.");
                    Console.ReadLine();
                    continue;
                }
                else if (operação == "3")
                {

                    resultado = n1int / n2int;




                }

                else if (operação == "4")
                {
                    resultado = n1int * n2int;
                }
               
                {
                    
                }
                     
                Console.WriteLine("O resultado é: " + resultado);
                Console.ReadLine(); 

            } 
            //
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }   }
}
