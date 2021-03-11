using System;

namespace Substituição_em_Vetor_I
{
    class SubstituiçãoVetor
    {
        static void Main(string[] args)
        {
            int[] X = new int[10];
            int y = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" Digite um valor para X[{i}] ");
                X[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (X[i] >= 0 && X[i] != null)
                {
                    Console.WriteLine($" X[{i}] = {X[i]}");
                }
                else
                {
                    X[i] = 1;
                    Console.WriteLine($" X[{i}] = {X[i]}");
                }
                
            }

        }
    }
}
