using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 ,num2 ,resp;
            Console.WriteLine("Milhas Para KM");
            Console.WriteLine("--------------");
            Console.Write("Entre com a medida (em milhas): ");
            num1= Convert.ToDouble(Console.ReadLine());
            num2 = 1.609;
            resp = num1 * num2;
            Console.WriteLine(resp);
        }
    }
}
