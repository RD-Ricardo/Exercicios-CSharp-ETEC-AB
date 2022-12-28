using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;
            Console.WriteLine("----------------");
            Console.WriteLine("--DoadorSangue--");
            Console.WriteLine("----------------");
            idade = Convert.ToDouble(Console.ReadLine());
            if(idade > 67){
                Console.WriteLine("Você não pode ser doador de sangue.");
            }
            else if(idade < 18){
                 Console.WriteLine("Você não pode ser doador de sangue.");
            }
            else{
                 Console.WriteLine("Você pode ser doador de sangue.");
            } 

        }
    }
}
