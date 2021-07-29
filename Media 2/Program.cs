using System;

namespace Novo_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            MEDIA = (A * 2) + (B * 3) + (C * 5) / 10;
            Console.WriteLine("MEDIA = {0:f1}", MEDIA);
            Console.ReadKey();

        }

    }

}
