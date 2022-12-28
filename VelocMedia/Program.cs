using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)


        { 
            double num1, num2 , resp,  resp2;
            Console.WriteLine("--------------");
            Console.WriteLine("--VelocMedia--");
            Console.WriteLine("--------------");
            Console.Write("Distância percorrida(m):");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Tempo gasto (s):");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            resp = num1 / num2;
            resp2 = Math.Floor(resp);
            Console.WriteLine($"Velociadae média: {resp2}m/s");
        }
    }
}
