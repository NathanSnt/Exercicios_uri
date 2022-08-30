using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double pesoNotaA = 3.5;
        double pesoNotaB = 7.5;
        double somaPeso = pesoNotaA * 1 + pesoNotaB * 1;

        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double somaNota = a * pesoNotaA + b * pesoNotaB;

        double media = somaNota / somaPeso;

        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }

}
