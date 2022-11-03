using System;

namespace uri_3048
{
    class URI
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] V = new int[N];
            int i = 0, x = 0;

            for (int v = 0; v < N; v++)
            {
                V[v] = int.Parse(Console.ReadLine());
            }

            for (int v = 0; v < N; v++)
            {
                x = (v == 0)? 0 : V[v-1];
                if (x != V[v])
                {
                    i++;
                }
            }

            Console.WriteLine(i);
        }
    }
}