using System;

namespace RetPreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            int largura, altura;
            Console.WriteLine("------------------");
            Console.WriteLine("Ret-Preenchimento");
            Console.WriteLine("------------------\n");
            Console.WriteLine("Tamanho do Retangulo");
            Console.Write("Largura...: ");
            largura =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Altura....: ");
            altura =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i< largura; i++)
            {
                Console.Write(" # ");
                for(int c = 1;  c< altura; c++)
                {
                    Console.Write(" # ");
                }
                Console.WriteLine();
            }
        }
    }
}
