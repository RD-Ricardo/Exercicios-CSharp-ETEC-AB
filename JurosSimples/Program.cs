using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {   

            double  num1, num2 , num3, resp, resp2;
            Console.WriteLine("-----------------");
            Console.WriteLine("--Juros Simples--");
            Console.WriteLine("-----------------");
            Console.Write("Capital[c] (R$) :");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Taxa de juros [i] (%): ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("tempo [c] (meses): ");
            num3 = Convert.ToDouble(Console.ReadLine());
            resp = (num1 * num2 * num3) / 100;
            resp2 = num1 + resp;
            Console.Write("\n");
            Console.WriteLine($"Juros (R$): {resp}");
            Console.WriteLine($"Montante (R$): {resp2}");
        }
    }
}
