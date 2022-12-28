using System;

namespace N_meros_e_operadores
{
    class Program
    {
        static void Main(string[] args)
        {   
            double num1, num2, resp;

            Console.WriteLine("Cálculo da soma entre dois números");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite o primeiro número:  ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o  segundo número:  ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resp = num1 + num2 ; 
            Console.Write($"Soma dos números: {resp}");
        }
    }
}
