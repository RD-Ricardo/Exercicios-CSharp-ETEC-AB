using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sexo;
            double num , resp;

            Console.WriteLine("-------------");
            Console.WriteLine("--PesoIdeal--");
            Console.WriteLine("-------------");
            Console.Write("Digite sua altura em m...: ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sexo [m]asculino / [f]eminino...: ");
            Sexo= Console.ReadLine();

            if(Sexo == "m"){
                resp = (num * 72.7) -58.0;
                Console.WriteLine($"Seu peso ideal é {resp}kg");
            }
            else if(Sexo == "f"){
                  resp = (num * 62.1)- 44.7;
                  Console.WriteLine($"Seu peso ideal é {resp}kg");
            }



        }
    }
}
