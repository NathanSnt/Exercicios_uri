using System;
using System.Globalization;

namespace uri_1155
{
    class URI
    {
        static void Main(string[] args)
        {
            double resultado;

            resultado = 0;
            for (int i = 1; i <= 100; i++)
            {
                resultado = resultado + 1.0 / i;
            }
            Console.WriteLine(resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
// 5.19