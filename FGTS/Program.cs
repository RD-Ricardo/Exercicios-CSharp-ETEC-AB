using System;

namespace FGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, resp;

            Console.WriteLine("--------");
            Console.WriteLine("--FGTS--");
            Console.WriteLine("--------");
            Console.Write("Digite seu salário(R$): ");
            num1 = Convert.ToDouble(Console.ReadLine());
            resp = num1 * 8 / 100;
            Console.Write($"FGTS: {resp.ToString("c")}");

        }
    }
}
