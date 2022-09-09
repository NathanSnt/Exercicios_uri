using System;

namespace uri_1099
{
    class URI
    {
        static void Main(string[] args)
        {
            string[] valores;
            int X, Y, soma = 0;
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                valores = Console.ReadLine().Split();
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);
                if (Y >= X)
                {
                    if (X % 2 != 0) { X++; }
                    for (int cont = X; cont < Y; cont++)
                    {
                        if (cont % 2 != 0)
                        {
                            soma += cont;
                        }
                    }
                }
                else
                {
                    if (Y % 2 != 0) { Y++; }
                    for (int cont = Y; cont < X; cont++)
                    {
                        if (cont % 2 != 0)
                        {
                            soma += cont;
                        }
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }

        }
    }
}