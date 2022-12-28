using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {    
            
            string txt;
            Console.WriteLine("Digite gritando");
             Console.WriteLine("--------------");
            txt = Console.ReadLine();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(txt.ToUpper());
            
        
            
        }
    }
}
