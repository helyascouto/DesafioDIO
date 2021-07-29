using System;

namespace Tempo_de_Jogo_com_Minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, minutoInicial, minutoFinal, horas, minutos;
            string[] s = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(s[0]);
            minutoInicial = int.Parse(s[1]);
            horaFinal = int.Parse(s[2]);
            minutoFinal = int.Parse(s[3]);

            horas = horaFinal - horaInicial;
            minutos = minutoFinal - minutoInicial;


            if (horaFinal > horaInicial && minutoFinal > minutoInicial)
            {
                horas = horaFinal - horaInicial;
                minutos = minutoFinal - minutoInicial;
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal < horaInicial && minutoFinal < minutoInicial)
            {
                horas = 23 - (horaInicial - horaFinal);
                minutos = 60 - (minutoInicial - minutoFinal);

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal > horaInicial && minutoFinal < minutoInicial)
            {
                horas = horaFinal - horaInicial;
                minutos = 60 - (minutoInicial - minutoFinal);

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }

            else if (horaFinal < horaInicial && minutoFinal > minutoInicial)
            {
                horas = 23 - (horaInicial - horaFinal);
                minutos = minutoFinal - minutoInicial;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal == horaInicial && minutoFinal == minutoInicial)
            {
                horas = 24;
                minutos = 0;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal > horaInicial && minutoFinal == minutoInicial)
            {
                horas = horaFinal - horaInicial;
                minutos = 0;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal < horaInicial && minutoFinal == minutoInicial)
            {
                horas = 23 - (horaInicial - horaFinal);
                minutos = 0;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal == horaInicial && minutoFinal < minutoInicial)
            {
                horas = 23;
                minutos = 60 - (minutoInicial - minutoFinal);

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }
            else if (horaFinal == horaInicial && minutoFinal > minutoInicial)
            {
                horas = 23;
                minutos = minutoFinal - minutoInicial;

                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
            }

            Console.ReadLine();
        }
    }
}
