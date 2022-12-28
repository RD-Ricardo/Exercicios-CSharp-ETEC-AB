using System;

namespace MaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Data de Agora
            DateTime now = DateTime.Now;
            string HoursNow = now.ToShortTimeString();
            //Data depos de 6 horas e 30 minutos
            DateTime later = now.AddHours(6.30);
            string laterTime = later.ToShortTimeString();
            Console.WriteLine("--------------");
            Console.WriteLine("--Mais tarde--");
            Console.WriteLine("--------------");
            Console.Write($"Agora {HoursNow}, mais tarde {laterTime}.");
        }
    }
}
