using System;

namespace uri_1172
{
    class URI
    {
        static void Main(string[] args)
        {
            int valor;
            int[] valores = new int[10];
            for (int x = 0; x < 10; x++)
            {
                valor = int.Parse(Console.ReadLine());
                valores[x] = valor > 0 ? valor : 1;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"X[{i}] = {valores[i]}");
            }
        }
    }
}