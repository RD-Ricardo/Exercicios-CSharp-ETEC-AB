using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num2, num3, x1, x2, D;
            bool convercao;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------");
            Console.WriteLine("----BHASKARA----");
            Console.WriteLine("----------------");            
            Console.WriteLine("\nDigite o valor de a: ");
            convercao = Double.TryParse(Console.ReadLine(), out num);
            if (num != 0)
            {
                Console.Write("\tDigite o valor de b: ");
                convercao = Double.TryParse(Console.ReadLine(), out num2);
                Console.Write("\tDigite o valor de c: ");
                convercao = Double.TryParse(Console.ReadLine(), out num3);
                D = Math.Pow(num2,2) - (4 * num * num3);
                if (D >= 0)
                {
                    double raiz = Math.Sqrt(D);
                    Console.WriteLine ($"\tO valor de DELTA é : {D} e sua raiz² é : {raiz} ");
                    x1= ((num2 * (-1)) + raiz) / (2 * num);
                    Console.WriteLine($"\tO valor de X1 é : {x1}");
                    x2= ((num2 * (-1)) - raiz) / (2 * num);
                    Console.WriteLine($"\tO valor de X2 é : {x2}");
                }
                else
                {
                    Console.WriteLine("\tEssa equação não possui raízes reais");
                }
            }
            else
            {
                Console.WriteLine("\tEssa equação não é de segundo grau");
            }

            Console.ResetColor();
            



        }
    }
}
