using System;

namespace uri_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = velocidade * tempo;
            double consumoKm = 12.0;

            double consumo = distancia / consumoKm;

            Console.WriteLine($"{consumo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
