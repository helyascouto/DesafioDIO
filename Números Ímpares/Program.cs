using System;

namespace Números_Ímpares
{
    class Program
    {
        public static void Main()
        {
            int n, x = -1;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            if (n > 0 && n <= 1000)
            {
                for (int i = 0; i < n; i++)
                {
                    i++;
                    x += 2;
                    Console.WriteLine("x" + x.ToString());
                }

            }
            Console.ReadLine();
        }

    }
}
