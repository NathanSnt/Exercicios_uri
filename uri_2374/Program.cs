using System;

namespace uri_2374
{
    class URI
    {
        static void Main(string[] args)
        {
            int pressaoDesejada = int.Parse(Console.ReadLine());
            int pressaoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine(pressaoDesejada - pressaoAtual);
        }
    }
}