using System;

namespace uri_2388
{
    class URI
    {
        static void Main(string[] args)
        {
            int distancia = 0;
            string[] valores;
            int N = int.Parse(Console.ReadLine());

            for (int x = 0; x < N; x++)
            {
                valores = Console.ReadLine().Split();
                distancia += int.Parse(valores[1]) * int.Parse(valores[0]);
            }
            Console.WriteLine(distancia);
        }
    }
}