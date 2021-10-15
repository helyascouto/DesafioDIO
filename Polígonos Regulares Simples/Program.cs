using System;

namespace Polígonos_Regulares_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split();
            int n1 = int.Parse(v[0]);
            int n2 = int.Parse(v[1]);

            Console.Write(n1 * n2);
        }
    }
}
