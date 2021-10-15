using System;

namespace Guilherme_e_Suas_Pipas
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long res = (N * (N - 3)) / 2;
            Console.WriteLine(res);
        }
    }
}
