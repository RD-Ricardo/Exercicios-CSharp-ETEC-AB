using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double  num ,num2 ,resp ;
            Console.WriteLine("-------");
            Console.WriteLine("Divisão");
            Console.WriteLine("-------");   
            Console.Write("Digite o numerador...: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o denominador...: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            resp = num /  num2;
            if(num2  == 0){
                Console.WriteLine("Não é posivel dividir por zero.");
            }
            else{
                 Console.WriteLine($"{num} dividido por {num2} é {resp}");
            }
        }
    }
}
