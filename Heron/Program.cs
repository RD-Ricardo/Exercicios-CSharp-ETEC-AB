using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3 , semiperimetro, area , resp;
            Console.WriteLine("Digite os lados do triangulo desejado.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Lado 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 2:");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 3:");
            num3 = Convert.ToDouble(Console.ReadLine());
            semiperimetro = (num1 + num2 + num3) / 2;
            area = semiperimetro *  (semiperimetro - num1) *(semiperimetro - num2) * (semiperimetro- num3);
            resp = Math.Sqrt(area);
            Console.WriteLine($"Semiperimetro{semiperimetro}");
            Console.Write($"Área é: {resp}");
        }
    }
}
