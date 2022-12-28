using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {   
            string frase;
            Console.WriteLine("Crinça Eduacada");
            Console.WriteLine("---------------");
            Console.WriteLine("chato/chata, bobo/boba, feio/feia");
            frase =  Console.ReadLine();
            frase = frase.Replace("chato", "#@$%*!&" ).Replace("chata", "#@$%*!&").Replace("bobo", "#@$%*!&").Replace("boba", "#@$%*!&").Replace("feio", "#@$%*!&").Replace("feia", "#@$%*!&");
            Console.WriteLine(frase);
        }
    }
}
