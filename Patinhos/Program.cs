using System.Runtime.InteropServices;
using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtPatinhos;
            Console.WriteLine("------------");
            Console.WriteLine("--Patinhos--");
            Console.WriteLine("------------\n");
            do{
                Console.Write("Quantos patinhos deseja começar...:");
                qtPatinhos= Convert.ToInt32(Console.ReadLine());
                if(qtPatinhos < 2)
                {
                    Console.WriteLine("Digite numeros maiores que 2");
                }
                
            }while(qtPatinhos < 2);

            for(int i  = qtPatinhos; i>0 ; i--)
            { 
                Console.WriteLine($"\n{i} patinhos foram passear ");
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Para brincar");
                Console.WriteLine("A mamãe gritou");
                if(i > 1)
                {
                    Console.WriteLine($"Quá, quá, quá, quá Mas só {i-1} patinhos voltaram de lá.");
                }
                if(i == 1)
                {
                    Console.WriteLine($"Quá, quá, quá, quá Mas só nenhum patinhos voltaram de lá.");
                    Console.WriteLine($"\nA mamãe patinha foi procurar");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Na beira do mar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    Console.WriteLine($"E os {qtPatinhos} patinhos voltaram de lá.");
                }    
            }
            
        }
    }
}
