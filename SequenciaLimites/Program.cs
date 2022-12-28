using System;

namespace SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("--Sequencia Limites--");
            Console.WriteLine("---------------------\n");
            Console.Write("Inicio...: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fim...: ");
            int fim = Convert.ToInt32(Console.ReadLine());
            if(inicio >= fim)
            {
                Console.Write("Deu erro!! o Campo Inicio não pode ser maior que o Fim!!");
            }
            else
            {
                for( int i = inicio; i <=fim ; i++)
                {
                    Console.WriteLine(i);    
                }
            }
            

        }
    }
}
