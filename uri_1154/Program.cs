using System;
using System.Globalization;

namespace uri_1154
{
    class URI
    {
        static void Main(string[] args)
        {
            int idade, soma = 0, qtd = 0;
            double media;

            while (true)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade < 0) { break; }
                soma += idade;
                qtd++;
            }
            media = soma / (float)qtd;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}