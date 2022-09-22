using System;
using System.Collections.Concurrent;

namespace uri_1774
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int, int[]> dicionario;
            int roteadores, cabos, R1, R2, custo, custoTotal;
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
                dicionario = dicionario.AddOrUpdate(R1, custo);
            }
            /*
            int roteadores, cabo, R1, R2, valorCabo, custoTot = 0, custo = 10000;
            string[] valores, infos;

            valores = Console.ReadLine().Split();

            roteadores = int.Parse(valores[0]);
            cabo = int.Parse(valores[1]);

            string[] lista = new string[cabo];

            for (int i = 0; i < cabo; i++)
            {
                infos = Console.ReadLine().Split();
                R1 = int.Parse(infos[0]);
                R2 = int.Parse(infos[1]);
                valorCabo = int.Parse(infos[2]);
                lista[i] = $"{R1} {R2} {valorCabo}";
            }

            int controle = 1;
            for (int i = 0; i < lista.Length; i++)
            {
                string r1 = lista[i].Split()[0];
                string metrica = lista[i].Split()[2];
                
                if (int.Parse(r1) == controle)
                {
                    if (int.Parse(metrica) < custo)
                    {
                        custo = int.Parse(metrica);
                        Console.WriteLine($"{lista[i]} = {metrica}");
                    }
                }
                else
                {
                    controle++;
                    i--;
                    custoTot += custo;
                    custo = 10000;
                }
            }
            Console.WriteLine(custoTot);
            */
        }
    }
}