using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {

            double  num1;
            Console.WriteLine("------------");
            Console.WriteLine("--Negativo--");
            Console.WriteLine("------------");
            Console.Write("Digite um número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            if(num1 <= 0 ){
                Console.WriteLine($"\nVocê digitou um número negativo {num1}");
            }
        }
    }
}
