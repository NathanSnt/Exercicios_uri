using System;
using System.Collections.Generic;

namespace uri_1774
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> lista = new List<string[]>();
            string[] valores;
            int roteadores, cabos, custo = 10001, total = 0;

            valores = Console.ReadLine().Split();
            roteadores = int.Parse(valores[0]);
            cabos = int.Parse(valores[1]);

            for (int i = 0; i < cabos; i++)
            {
                lista.Add(Console.ReadLine().Split());
            }

            int router = 1;

            while (router <= roteadores)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (int.Parse(lista[i][0]) == router && int.Parse(lista[i][2]) < custo) 
                    { 
                        custo = int.Parse(lista[i][2]); 
                    }
                }
                total += (custo == 10001)? 0 : custo;
                custo = 10001;
                router++;
            }
            Console.WriteLine(total);
        }
    }
}