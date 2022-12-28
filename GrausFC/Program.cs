using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {   
            double num1, resp;

            Console.WriteLine("GrausFC");
            Console.WriteLine("-------");
            Console.Write("Digite um temperatura:");
            num1 = Convert.ToDouble(Console.ReadLine());
            resp =( num1 - 32  ) /  1.8;
            Console.WriteLine($"°F = {num1}");
            Console.WriteLine($"{num1}°F equivalem a {resp.ToString("f")}°F");
            

        }
    }
}
