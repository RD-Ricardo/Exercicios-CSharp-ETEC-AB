using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {  
            string frase;
            Console.WriteLine("Cebolinha");
            Console.WriteLine("---------");
            Console.WriteLine("Digite um frase");
            frase =  Console.ReadLine();
            frase = frase.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L");
            Console.WriteLine(frase);            

        }
    }
}
