using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {   

            double num1,num2;
            Console.WriteLine("-------------------");
            Console.WriteLine("--Maior 2 Numeros--");
            Console.WriteLine("-------------------");
            Console.Write("Digite o primeiro número...:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número...:");
            num2 = Convert.ToDouble(Console.ReadLine());
            if(num1 > num2){
                Console.WriteLine($"o maio número é {num1}");
            }
            else if (num1 < num2){
                 Console.WriteLine($"o maio número é {num2}");
            }


        }
    }
}
