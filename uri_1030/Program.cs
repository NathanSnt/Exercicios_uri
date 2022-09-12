using System;

namespace uri_1030
{
    class URI
    {
        static void Main(string[] args)
        {
            int casos, pessoas, salto;
            casos = int.Parse(Console.ReadLine());

            for (int c = 1; c <= casos; c++)
            {
                string[] valores = Console.ReadLine().Split();
                List<int> soldados = new List<int>();
                pessoas = int.Parse(valores[0]);
                salto = int.Parse(valores[1]);

                for (int i = 1; i <= pessoas; i++)
                {
                    soldados.Add(i);
                }

                int soldado = 0, vivos = soldados.ToArray().Length;
                while (vivos > 1)
                {
                    soldado += salto;
                    if (soldado > vivos)
                    {
                        soldado = 0 + (soldado - vivos);
                        if (soldado > vivos) { soldado--; }
                    }
                    try
                    {
                        soldados.RemoveAt(soldado-1);
                        soldado--;
                    }
                    catch
                    {
                        if (soldado > vivos)
                        {
                            soldado--;
                            //soldado = 0 + (soldado - vivos);
                        }
                        else
                        {
                            soldado++;
                        }
                    }
                    vivos--;
                }
            Console.WriteLine($"Case {c}: {soldados[0]}");
            }
            /*
            int vivos;
            int casos = int.Parse(Console.ReadLine());
            string[] valores;
            int[] pessoas = {};
            for (int i = 1; i <= casos; i++) // Número de casos.
            {
                valores = Console.ReadLine().Split();
                int pessoa = int.Parse(valores[0]);
                int salto = int.Parse(valores[1]);
                vivos = pessoa;
                for (int j = 1; j <= pessoa; j++) // Criar vetor com a quantidade de pessoas.
                {
                    var lista = pessoas.ToList();
                    lista.Add(j);
                    pessoas = lista.ToArray();
                }

                int morte = 0, loop = 0;

                while (pessoas.Length > 1)
                {
                    morte += salto;
                    if (morte > pessoas.Length) 
                    { 
                        if (loop > 1)
                        {
                            morte = -1;
                        }
                        else
                        {
                        morte -= vivos; 
                        loop++;
                        }
                    }
                    else 
                    {
                        var lista = pessoas.ToList();
                        lista.RemoveAt(morte-1);
                        pessoas = lista.ToArray();
                        loop--;
                        morte--;
                        vivos--;
                    }
                }
                Console.WriteLine($"Case {i}: {pessoas[0]}");
            }
                */
        }
    }
}