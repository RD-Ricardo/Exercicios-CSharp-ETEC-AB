using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nome;
            Console.WriteLine("Digite seu nome");
            Console.WriteLine("----------------");
            nome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\n Olá {nome}");
        }
    }
}
