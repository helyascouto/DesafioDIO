using System;

namespace Preenchimento_de_Vetor_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            int cont = 0;
            int res = 0;
            n[0] = valorLido;
            res = valorLido;

            for (int i = 1; i < 10; i++)
            {
                res = n[i - 1];
                n[i] = res * 2;

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, n[i]);
            }

        }
    }
}
