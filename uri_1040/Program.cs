using System;
using System.Globalization;

namespace uri_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            int p1 = 2;
            int p2 = 3;
            int p3 = 4;
            int p4 = 1;

            double media = (n1 * p1 + n2 * p2 + n3 * p3 + n4 * p4) / (p1 + p2 + p3 + p4);
            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {n5.ToString("F1", CultureInfo.InvariantCulture)}");
                
                media = (media + n5) / 2.0;

                if (media >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (media < 5)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}