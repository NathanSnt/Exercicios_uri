using System;

namespace uri_1061
{
    class URI
    {
        static void Main(string[] args)
        {

            int dia = 0, hora = 0, minuto = 0, segundo = 0, diaI, horaI, minutoI, segundoI, diaF, horaF, minutoF, segundoF;
            string[] diaInicio = Console.ReadLine().Split();
            string[] horarioInicio = Console.ReadLine().Split(':');
            string[] diaFim = Console.ReadLine().Split();
            string[] horarioFim = Console.ReadLine().Split(':');

            diaI = int.Parse(diaInicio[1]);
            horaI = int.Parse(horarioInicio[0]);
            minutoI = int.Parse(horarioInicio[1]);
            segundoI = int.Parse(horarioInicio[2]);

            diaF = int.Parse(diaFim[1]);
            horaF = int.Parse(horarioFim[0]);
            minutoF = int.Parse(horarioFim[1]);
            segundoF = int.Parse(horarioFim[2]);


            while(diaI != diaF || horaI != horaF || minutoI != minutoF || segundoI != segundoF)
            {
                segundo++;
                if (segundo == 60)
                {
                    segundo = 0;
                    minuto++;
                    if (minuto == 60)
                    {
                        minuto = 0;
                        hora++;
                        if (hora == 24)
                        {
                            hora = 0;
                            dia++;
                        }
                    }
                }

                segundoI++;
                if (segundoI == 60)
                {
                    segundoI = 0;
                    minutoI++;
                    if (minutoI == 60)
                    {
                        minutoI = 0;
                        horaI++;
                        if (horaI == 24)
                        {
                            horaI = 0;
                            diaI++;
                        }
                    }
                }
            }
            Console.WriteLine($"{dia} dia(s)");
            Console.WriteLine($"{hora} hora(s)");
            Console.WriteLine($"{minuto} minuto(s)");
            Console.WriteLine($"{segundo} segundo(s)");
        }

    }
}