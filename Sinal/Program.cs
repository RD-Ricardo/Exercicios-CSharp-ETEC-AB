using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {   
            double num;
            Console.WriteLine("---------");
            Console.WriteLine("--Sinal--");
            Console.WriteLine("---------");
            Console.Write("Digite um número:  ");
            num = Convert.ToDouble(Console.ReadLine());
            if(num >= 1){
                Console.WriteLine("Positivo");
            }
            else if(num < 0){
                Console.WriteLine("Negativo");
            }
            else if(num == 0 ){
                Console.WriteLine("Zero");
            }
        }
    }
}
