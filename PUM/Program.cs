using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int primeiro = 1;



            for (int i = 1; i <= N * 4; i++)
            {

                if (i % 4 != 0)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    Console.Write("PUM\n");
                }

                //if (primeiro < 4)
                //{
                //    Console.Write(i + " ");
                //    primeiro++;
                //}
                //if (primeiro == 4)
                //{
                //    primeiro = 1;
                //    Console.Write("PUM\n");
                //}
            }

        }
    }
}

