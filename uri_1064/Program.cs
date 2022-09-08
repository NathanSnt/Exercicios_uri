using System;
using System.Globalization;

namespace uri_1064
{
    class URI
    {

        static void Main(string[] args)
        {
            double valor, soma = 0, media;
            int contador = 0;
            for (int x = 0; x < 6; x++)
            {
                valor = double.Parse(Console.ReadLine());
                if (valor > 0)
                {
                    contador++;
                    soma += valor;
                }
            }
            media = soma / contador;
            Console.WriteLine($"{contador} valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

        }

    }
}
