using System;

namespace Pneu
{
    class Program
    {
        static void Main(string[] args)
        {
            var pressãoDesejada = int.Parse(Console.ReadLine());
            var pressaoPneu = int.Parse(Console.ReadLine());
            var res = pressãoDesejada - pressaoPneu;

            Console.WriteLine(res);

        }
    }
}
