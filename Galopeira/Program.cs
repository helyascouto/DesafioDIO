using System;

namespace Galopeira
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 0; i < x; i++)
            {
                string texto = Console.ReadLine();
                for (int I = 0; I < texto.Length + 1; I++)
                {
                    res = I;
                }
                Console.WriteLine("0.{0}", res);
            }
        }
    }
}
