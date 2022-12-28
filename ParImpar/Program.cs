using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            double num;
            Console.WriteLine("---------------");
            Console.WriteLine("---Par Impar---");
            Console.WriteLine("---------------");
            Console.Write("Digite um  número:  ");
            num = Convert.ToDouble(Console.ReadLine());
            if(num % 2 == 0){
                Console.WriteLine("\nNúmero par");
            }
            else{
                Console.WriteLine("\nNúmero Impar");
            }

        }
    }
}
