using System;
using System.Globalization;

namespace uri_1156
{
    class URI
    {
        static void Main(string[] args)
        {
            double resultado = 1;
            int somador = 2;

            for (int i = 3; i <= 39; i += 2)
            {
                resultado = resultado + (double)i / somador;
                somador += somador;
            }
            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
// 6.00