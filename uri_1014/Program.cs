using System;

namespace uri_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia = int.Parse(Console.ReadLine());
            float gasto = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            float gastoKm = distancia / gasto;
            Console.WriteLine($"{gastoKm.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)} km/l");
        }
    }
}   
