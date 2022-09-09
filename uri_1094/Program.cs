using System;
using System.Globalization;

namespace uri_1094
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            int x, quantia, r = 0, s = 0, c = 0, total = 0;
            char tipo;
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                valores = Console.ReadLine().Split();
                quantia = int.Parse(valores[0]);
                tipo = char.Parse(valores[1]);
                if (tipo == 'R')
                {
                    r +=  quantia;
                }
                else if (tipo == 'S')
                {
                    s += quantia;
                }
                else if (tipo == 'C')
                {
                    c += quantia;
                }
                total += quantia;
            }
            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {c}");
            Console.WriteLine($"Total de ratos: {r}");
            Console.WriteLine($"Total de sapos: {s}");
            Console.WriteLine($"Percentual de coelhos: {(c * 100.00 / total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {(r * 100.00 / total).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {(s * 100.00 / total).ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}