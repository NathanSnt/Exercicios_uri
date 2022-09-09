using System;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;

namespace uri_1113
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            int X=1;
            int Y=2;

            while (X != Y)
            {
                valores = Console.ReadLine().Split();
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (Y > X)
                {
                    Console.WriteLine("Crescente");
                }
            }
        }
    }
}