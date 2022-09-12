using System;
using System.Globalization;

namespace uri_1118
{
    class URI
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            string novo;

            while (true)
            {
                while (true)
                {
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (n1 >= 0 && n1 <= 10) { break; }
                    Console.WriteLine("nota invalida");
                }

                while (true)
                {
                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (n2 >= 0 && n2 <= 10) { break; }
                    Console.WriteLine("nota invalida");
                }
                media = (n1 + n2) / 2.0;
                Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

                while (true)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novo = Console.ReadLine();

                    if (novo == "2" || novo == "1") { break; }
                }
                if (novo == "2") { break; }
            }
        }
    }
}