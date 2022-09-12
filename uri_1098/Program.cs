using System;
using System.Globalization;

namespace uri_1098
{
    class URI
    {
        static void Main(string[] args)
        {
            double controle = 1;
            for (double i = 0; i <= 2; i += 0.2)
            {
                for (double j = controle; j <= controle + 2; j++)
                {
                    Console.WriteLine($"I={Math.Round(i, 1).ToString().Replace(',', '.')} J={Math.Round(j, 1).ToString().Replace(',', '.')}");
                }
                controle += 0.2;
            }

        }
    }
}