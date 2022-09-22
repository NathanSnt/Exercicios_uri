using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace uri_1774
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> dicionario = new Dictionary<int, List<int>>();

            int roteadores, cabos, R1, R2, custo, custoTotal = 0;
            string[] valores, entradas;
            
            valores = Console.ReadLine().Split();

            roteadores = int.Parse(valores[0]);
            cabos = int.Parse(valores[1]);

            for (int i = 0; i < cabos; i++)
            {
                entradas = Console.ReadLine().Split();
                
                R1 = int.Parse(entradas[0]);
                R2 = int.Parse(entradas[1]);
                custo = int.Parse(entradas[2]);

                if (!dicionario.ContainsKey(R1)) { dicionario[R1] = new List<int>(); }
                dicionario[R1].Add(custo);

                if (!dicionario.ContainsKey(R2)) { dicionario[R2] = new List<int>(); }
                dicionario[R2].Add(custo);
            }

            List<List<int>> conectados;

            //for (int i = 1; i <= roteadores; i++)
            int c = 1;
            while (c <= roteadores)
            {


                custoTotal += dicionario[c].Min();
                Console.WriteLine($"{dicionario[c].Min()} é o menor link de R{c}");
                c++;
            }

            Console.WriteLine(custoTotal);
        }
    }
}