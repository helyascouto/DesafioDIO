using System;

namespace Triângulo
{
    class Triângulo
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if ((a == b) && (b == c) && (c == a)) //complete a condicional
            {
                double perímetro = a + b + c;
                Console.WriteLine("Perimetro = {0:0.0}", perímetro); //complete a saida
            }
            else
            {
                double area = ((a + b) * c) / 2;
                Console.WriteLine("Area = {0:0.0}", area); //complete a saida
            }
        }
    }
}
