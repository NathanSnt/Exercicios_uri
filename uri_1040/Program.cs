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

            double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4) / 10.0;
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

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
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