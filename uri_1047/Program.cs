using System;

namespace uri_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, minutoInicio, horaFim, minutoFim, horaDuracao = 0, minutoDuracao = 0;

            string[] valores = Console.ReadLine().Split();
            horaInicio = int.Parse(valores[0]);
            minutoInicio = int.Parse(valores[1]);
            horaFim = int.Parse(valores[2]);
            minutoFim = int.Parse(valores[3]);
            
            if (horaInicio > horaFim)
            {
                //while (horaInicio != horaFim && minutoInicio != minutoFim)
                while (horaInicio != horaFim || minutoInicio != minutoFim)
                {
                    minutoInicio++;
                    if (minutoInicio == 60)
                    {
                        horaInicio++;
                        minutoInicio = 0;
                        if (horaInicio == 24)
                        {
                            horaInicio = 0;
                        }
                    }

                    minutoDuracao++;
                    if (minutoDuracao == 60)
                    {
                        horaDuracao++;
                        minutoDuracao = 0;
                    }
                }
            }
            //else if (horaInicio == horaFim && minutoInicio == minutoFim)
            else if (horaInicio == horaFim || minutoInicio == minutoFim)
            {
                minutoInicio++;
                //while ((horaInicio != horaFim) && (minutoInicio != minutoFim))
                while ((horaInicio != horaFim) || (minutoInicio != minutoFim))
                {
                    minutoInicio++;
                    if (minutoInicio == 60)
                    {
                        horaInicio++;
                        minutoInicio = 0;
                        if (horaInicio == 24)
                        {
                            horaInicio = 0;
                        }
                    }

                    minutoDuracao++;
                    if (minutoDuracao == 60)
                    {
                        horaDuracao++;
                        minutoDuracao = 0;
                    }
                }
                minutoDuracao++;
                if (minutoDuracao == 60)
                {
                    horaDuracao++;
                    minutoDuracao = 0;
                }
            }
            else if (horaInicio < horaFim)
            {
                //while (horaInicio != horaFim && minutoInicio != minutoFim)
                while (horaFim > horaInicio || minutoFim > minutoInicio)
                {
                    if (minutoDuracao == 60)
                    {
                        minutoDuracao = 0;
                        horaDuracao++;
                    }
                    minutoDuracao++;
                    
                    if (minutoFim == 0)
                    {
                        minutoFim = 60;
                        horaFim--;
                    }
                    minutoFim--;
                }
            }

            Console.WriteLine($"O JOGO DUROU {horaDuracao} HORA(S) E {minutoDuracao} MINUTO(S)");
        }

    }
}