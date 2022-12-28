using System;

namespace Nome_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            Console.WriteLine("Digite seu  primerio  nome");
            nome =  Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            sobrenome =  Console.ReadLine();
            Console.WriteLine($"Nome completo: {nome}{sobrenome}");
            Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
        }
    }
}
