using System;

namespace Área_do_Círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159, R, A;


            R = Convert.ToDouble(Console.ReadLine());

            A = PI * (R * R);

            Console.WriteLine("  A={0}", A.ToString("0.0000"));
        }
    }
}
