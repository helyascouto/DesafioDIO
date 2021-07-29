using System;

namespace Média_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, media;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            media = ((2 * a + 3 * b + 4 * c + d) / 10);

            Console.WriteLine("Media: " + media.ToString("0.0"));
            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (media < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (media > 5 && media < 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0}", e);
                media = (media + e) / 2;
                if (media > 5)
                {
                    Console.WriteLine("Aluno aprovado");
                }
                if (media <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " + media.ToString("0.0"));
            }


            Console.ReadKey();
        }
    }
}
