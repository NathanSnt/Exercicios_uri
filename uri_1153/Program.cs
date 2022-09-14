using System;

namespace uri_1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fator = 1;

            for (int i = N; i > 0; i--)
            {
                fator *= i;
            }
            Console.WriteLine(fator);
        }
    }
}
