using System;
using System.Globalization;

namespace uri_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            // Funciona, mas encontrei forma mais precisar de resolver isso. Está ao final do código.
            int meio, maior, menor;
            meio = maior = menor = int.Parse(valores[0]);
            for (int x = 0; x < 3; x++)
            {
                if (int.Parse(valores[x]) > maior)
                {
                    maior = int.Parse(valores[x]);
                }
                else if (int.Parse(valores[x]) < menor)
                {
                    menor = int.Parse(valores[x]);
                }
                else
                {
                    meio = int.Parse(valores[x]);
                }
            }

            Console.WriteLine($"{menor}\n{meio}\n{maior}\n");

            foreach (string valor in valores)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
/*
double A, B, C; // Trocar A por Maior, B por Meio e C por Menor.
double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

if (a > b && a > c)
{
    A = a;
    if (b > c)
    {
        B = b;
        C = c;
    }
    else
    {
        B = c;
        C = b;
    }
}
else if (b > c)
{
    A = b;
    if (a > c)
    {
        B = a;
        C = c;
    }
    else
    {
        B = c;
        C = a;
    }
}
else
{
    A = c;
    if (a > b)
    {
        B = a;
        C = b;
    }
    else
    {
        B = b;
        C = a;
    }
}
*/