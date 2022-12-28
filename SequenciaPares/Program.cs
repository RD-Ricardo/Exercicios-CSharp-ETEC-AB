using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("--Sequencia de Pares--");
            Console.WriteLine("---------------------\n");
            Console.Write("Números pares entre 0 e...: ");
            int num =  Convert.ToInt32(Console.ReadLine());
            for(int i  = 0; i<=num;i++)
            {
                if(i % 2 == 0)
                {
                   Console.WriteLine(i);
                }
            }
        }
    }
}
