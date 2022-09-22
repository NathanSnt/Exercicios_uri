using System;
using System.Globalization;

namespace uri_1054
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, qtd = 0, soma = 0;
            double media;

            while (true)
            {
                idade = int.Parse(Console.ReadLine());
                if (idade < 0) { break; }
                soma += idade;
                qtd++;
            }
            media = soma / qtd;
            Console.WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
