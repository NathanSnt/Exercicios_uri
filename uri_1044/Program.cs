using System;

namespace uri_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (b >= a)
            {
                while (b > 0)
                {
                    b -= a;
                }
            }
            else
            {
                while (a > 0)
                {
                    a -= b;
                }
            }
            if (b == 0 || a == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
            /*
            long sobra = 0;
            Math.DivRem(b, a, out sobra);
            if (sobra == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            */
        }
    }
}