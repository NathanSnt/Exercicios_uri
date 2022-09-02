using System;

namespace uri_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInformada = int.Parse(Console.ReadLine());
            int hora, minuto, segundos;

            hora = horaInformada / (60 * 60); // Retirando os segundos que representam a hora
            horaInformada -= hora * (60 * 60); // Decrementando os segundos que representam a hora do valor informado

            minuto = horaInformada / 60; // Retirando os segundos que representam os minutos
            horaInformada -= minuto * 60; // Decrementando os segundos que representam os minutos do valor informado

            segundos = horaInformada; // O restante é o valor que representa os segundos

            Console.WriteLine($"{hora}:{minuto}:{segundos}");
        }
    }
}
