using System;
using Humanizer;
using Figgle;


namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-----------------");
            Console.WriteLine("--Digite seu Nome");
            Console.WriteLine("-----------------");
            string name = Console.ReadLine();
            string textao = FiggleFonts.Standard.Render(name);
            Console.WriteLine(textao);
        }
    }
}
