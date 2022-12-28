using System;

namespace GrausCF
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, resp;
            Console.WriteLine("GrausCF");
            Console.WriteLine("--------");
            Console.Write("Digite a temperatura atual:");
            num1 = Convert.ToDouble(Console.ReadLine());
            resp = (num1 * 1.8) + 32;
            Console.WriteLine($"{num1}°C equivalem a {resp}°F");


                    
        }
    }
}
