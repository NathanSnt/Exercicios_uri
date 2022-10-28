using System;
using System.Net;

namespace uri_1175
{
    class URI
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[20];

            for (int x = 0; x < 20; x++)
            {
                vetor[x] = int.Parse(Console.ReadLine());
            }

            int helper;
            for (int x = 0; x < 10; x++)
            {
                helper = vetor[x];
                vetor[x] = vetor[19 - x];
                vetor[19 - x] = helper;
            }

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine($"N[{x}] = {vetor[x]}");
            }
        }
    }
}