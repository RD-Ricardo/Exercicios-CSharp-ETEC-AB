using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)

        {  
            double  num1, num2, resp;

            Console.WriteLine("-------");
            Console.WriteLine("--IMC--");
            Console.WriteLine("-------");
            Console.Write("Digite sua Altura(m): ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu Peso(kg): ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resp = (num2 / num1) / 2;
            Console.WriteLine($"IMC: {resp} kg/m");

        }
    }
}
