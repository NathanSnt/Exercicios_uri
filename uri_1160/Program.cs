using System;
using System.Globalization;

namespace uri_1160
{
    class URI
    {
        static void Main(string[] args)
        {
            int casos, populacaoA, populacaoB, anos;
            double crescimentoA, crescimentoB;
            string[] valores;

            casos = int.Parse(Console.ReadLine());

            for (int i = 0; i < casos; i++)
            {
                valores = Console.ReadLine().Split();
                populacaoA = int.Parse(valores[0]);
                populacaoB = int.Parse(valores[1]);
                crescimentoA = double.Parse(valores[2], CultureInfo.InvariantCulture);
                crescimentoB = double.Parse(valores[3], CultureInfo.InvariantCulture);
                anos = 0;
                while (populacaoA <= populacaoB && anos <= 100)
                {
                    populacaoA += (int)(populacaoA * (crescimentoA / 100));
                    populacaoB += (int)(populacaoB * (crescimentoB / 100));
                    anos++;
                }
                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}