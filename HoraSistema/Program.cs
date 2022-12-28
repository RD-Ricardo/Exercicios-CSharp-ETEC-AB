using System;

namespace HoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Hora do sistema--");
            Console.WriteLine("-------------------");
            DateTime now = DateTime.Now;
            Console.WriteLine($"Neste momento são exatamente {now}.");
            
        }
    }
}
