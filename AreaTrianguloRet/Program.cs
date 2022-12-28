using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, altura , resp;
            Console.WriteLine("Area Triangulo");
            Console.WriteLine("--------------");
            Console.Write("Digite a Base: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            resp = (b * altura) / 2;
            Console.WriteLine($"Área é: {resp}");
             
        }
    }
}
