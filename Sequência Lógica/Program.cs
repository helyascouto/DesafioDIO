using System;

namespace Sequência_Lógica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int a = 1, b = 1, c = 1, a2 = 1, b2 = 1, c2 = 1;

            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                a = i;
                b = a * a;
                c = a * b;

                a2 = i;
                b2 = b + 1;
                c2 = c + 1;

                Console.WriteLine("{0} {1} {2}", a, b, c);
                Console.WriteLine("{0} {1} {2}", a2, b2, c2);

            }

        }
    }
}
