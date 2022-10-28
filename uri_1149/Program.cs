using System;
using System.Xml.Serialization;

namespace uri_1149 
{ 
    class URI
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split();
            int A, N = 0, soma = 0;

            A = int.Parse(valores[0]);

            for (int x = 1; x < valores.Length; x++)
            {
                if (int.Parse(valores[x]) > 0)
                {
                    N = int.Parse(valores[x]);
                }
            }

            for (int x = A; x < A + N; x++)
            {
                soma += x;
            }

            Console.WriteLine(soma);
        }

    }
}