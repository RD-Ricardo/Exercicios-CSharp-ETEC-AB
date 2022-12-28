using System;

namespace Elefante
{
    class Program
    {
        static void Main(string[] args)
        {
            int elefante;
            Console.WriteLine("------------");
            Console.WriteLine("--Elefante--");
            Console.WriteLine("------------\n");
            Console.Write("Quantos elefantes: ");
            do{
                elefante = Convert.ToInt32(Console.ReadLine());
                if( elefante % 2 !=0)
                {
                    Console.Write("Digite somente numeros pares:");
                }
                Console.WriteLine();

            }while(elefante % 2 !=0);

            for(int i = 0 ; i < elefante; i++)
            {
              Console.Write($"{i + 1} elefantes");
            
                if(i % 2  ==0)
                {  
                    Console.WriteLine(" muita gente");  
                }
                
                if(i % 2 != 0)
                {
                    for(int c = 0 ; c <= i; c++)
                    {
                        Console.Write(" incomodam");
                    }
                    Console.WriteLine(" muito mais\n");
                }  
            } 
        }
    }
}
