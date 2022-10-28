namespace uri_1173
{
    using System;

    class URI
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int[] N = new int[10];

            N[0] = valor;

            for (int x = 1; x < 10; x++)
            {
                N[x] = N[x-1] + N[x-1];
            }

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine($"N[{x}] = {N[x]}");
            }
        }
    }
}