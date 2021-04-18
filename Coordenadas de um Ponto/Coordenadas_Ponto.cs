using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coordenadas_de_um_Ponto
{
    class Coordenadas_Ponto
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double X = double.Parse(input[0]);
            double Y = double.Parse(input[1]);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0 && Y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (X != 0 && Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
