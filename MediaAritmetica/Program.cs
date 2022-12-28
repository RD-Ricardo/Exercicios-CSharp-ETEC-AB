using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 , num2, num3 , resp;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("--Média Aritmética de 3 números--");
            Console.WriteLine("---------------------------------");
            Console.Write("Digite o primeiro numero: ");
            num1 =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o primeiro numero: ");
            num2 =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o primeiro numero: ");
            num3 =  Convert.ToDouble(Console.ReadLine());
            resp =  (num1 + num2  + num3) / 3;
            Console.Write($"Média: {resp}");
        }
    }
}
