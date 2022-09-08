using System;
using System.Collections.Generic;

namespace uri_1050
{
    class URI
    {
        static void Main(string[] args)
        {
            int ddd = int.Parse(Console.ReadLine());

            Dictionary<int, string> tabela = new Dictionary<int, string>()
            {
                {61, "Brasilia"},
                {71 ,"Salvador"},
                {11 ,"Sao Paulo"},
                {21 ,"Rio de Janeiro"},
                {32 ,"Juiz de Fora"},
                {19 ,"Campinas"},
                {27 ,"Vitoria"},
                {31 ,"Belo Horizonte"}
            };

            tabela.TryGetValue(ddd, out string s);
            if (s == null)
            {
                Console.WriteLine("DDD nao cadastrado");
            }
            else
            {
                Console.WriteLine(tabela[ddd]);
            }

        }

    }
}