﻿using System;

namespace Tempo_de_um_Evento
{
    class Tempo_de_Evento
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split(" ");
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);

            string[] dadosTermino = Console.ReadLine().Split(" ");
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

            int Segundo = (segundoMomentoTerminio - segundoMomentoInicio);
            int Minuto = (minutoMomentoTermino - minutoMomentoInicio);
            int Hora = (horaMomentoTermino - horaMomentoInicio);
            int Dia = (diaTermino - diaInicio);

            if (Segundo < 0)
            {
                Segundo += 60;
                Minuto--;
            }

            if (Minuto < 0)
            {
                Minuto += 60;
                Hora--;
            }

            if (Hora < 0)
            {
                Hora += 24;
                Dia--;
            }

            Console.WriteLine(Dia + " dia(s)");
            Console.WriteLine(Hora + " hora(s)");
            Console.WriteLine(Minuto + " minuto(s)");
            Console.WriteLine(Segundo + " segundo(s)");
        }

    }

}
