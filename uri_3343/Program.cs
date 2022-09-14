using System;

namespace uri_3343
{
    class URI
    {
        static void Main(string[] args)
        {
            int p, m, g, x, n, muralhas = 0, tot = 0;
            string[] valores, tamanhos;
            string titas;

            valores = Console.ReadLine().Split();
            titas = Console.ReadLine();
            tamanhos = Console.ReadLine().Split();

            n = int.Parse(valores[0]); // Quantidade de titãs
            x = int.Parse(valores[1]); // Tamanho da muralha
            p = int.Parse(tamanhos[0]); // Tamanho do titã pequeno
            m = int.Parse(tamanhos[1]); // Tamanho do titã médio
            g = int.Parse(tamanhos[2]); // Tamanho do titã grande

            for (int t = 0; t < n; t++)
            {
                if (titas[t].Equals('P')) { tot += p; }
                else if (titas[t].Equals('M')) { tot += m; }
                else if (titas[t].Equals('G')) { tot += g; }
            }

            while (tot > 0)
            {
                tot -= x;
                muralhas++;
            }
            Console.WriteLine(muralhas);
        }
    }
}