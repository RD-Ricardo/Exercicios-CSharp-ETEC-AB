using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 , cm , metro , km;
            Console.WriteLine("Medidas");
            Console.WriteLine("-------");
            Console.Write("Entre com a medida (em metros):  ") ;
            num1 = Convert.ToDouble(Console.ReadLine());
            cm = num1 * 100;
            Console.WriteLine($"{cm} cm ");
            metro = num1 * 1;
            Console.WriteLine($"{metro} m");
            km = num1  * 0.001;
            Console.WriteLine($"{km} km ");
        }
    }
}
