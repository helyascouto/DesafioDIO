using System;



class Program
{
    public static void Main()

    {
        double a, b = 0, avg;
        int i, positive = 0;

        for (i = 0; i < 6; i++)
        {
            a = int.Parse(Console.ReadLine());

            if (a >= 0)
            {
                positive++;

                b += a;
            }

        }

        avg = b / positive;
        avg = Math.Round(avg, 1);

        Console.WriteLine("{0} valores positivos", positive);
        Console.WriteLine("{0:f1}", avg);

    }

}