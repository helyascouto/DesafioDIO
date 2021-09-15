using System;

namespace Conversão_de_Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());


            //continue a solucao


            var hours = (timeInSeconds / 60) / 60;

            var minutes = (timeInSeconds / 60) % 60;

            var seconds = timeInSeconds % 60;


            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
