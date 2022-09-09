using System;
using System.Globalization;

namespace uri_1117
{
    class URI
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            while (true)
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n1 >= 0 && n1 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }

            while (true)
            {
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (n2 >= 0 && n2 <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }

            }

            media = (n1 + n2) / 2;
            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}