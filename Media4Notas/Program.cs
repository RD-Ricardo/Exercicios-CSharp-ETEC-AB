using System;

namespace Media4notas
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] Notas = new double[5];
            double soma = 0;
            double resp;
            int c;
            
            Console.WriteLine("------------------");
            Console.WriteLine("--Media de Notas--");
            Console.WriteLine("------------------");
            Console.WriteLine("Digite Suas notas Abaixo");

            for (c = 1; c < Notas.Length; c++)
            {
                double nota;
                Console.Write($"Nota {c}: ");

                nota = Convert.ToDouble(Console.ReadLine());

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("\nDigite somente notas entre 0 a 10 ");
                    c--;
                    continue;
                }

                soma += nota;
                Notas[c] = nota;
            }

            resp = soma / 4;

            if (resp > 6)
            {
                Console.WriteLine($"Você ficou com média {resp}. Resultado: Aprovado");
            }
            else if (resp >= 5 & resp <= 6)
            {
                Console.WriteLine($"Você ficou com média {resp}. Resultado: Recuperação");
            }
            else if (resp < 5)
            {
                Console.WriteLine($"Você ficou com média {resp}. Resultado: Reprovado");
            }

        }
    }
}
