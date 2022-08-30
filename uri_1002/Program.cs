using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        double n = 3.14159;
        double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double a = n * Math.Pow(r, 2);
        Console.WriteLine($"A={a.ToString("F4", CultureInfo.InvariantCulture)}");
    }

}