using System;
using System.Globalization;

namespace uri_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            double A, B, C;
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

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if ((A == B && B != C) || (B == C && C != A) || (C == A && A != B))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
            //Console.WriteLine($"A = {A}\nB = {B}\nC = {C}\n\nA² = {Math.Pow(A, 2)}\nB² = {Math.Pow(B, 2)}\nC² = {Math.Pow(C, 2)}\nB² + C² = {Math.Pow(B, 2) + Math.Pow(C, 2)}");
        }
    }
}