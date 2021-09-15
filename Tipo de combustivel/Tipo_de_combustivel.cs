using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_combustivel_1
{
    class Tipo_de_combustivel
    {
        static void Main(string[] args)
        {
            int[] contador = new int[3];
            int codigo = 0;

            do
            {
                codigo = Convert.ToInt32(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        contador[0]++;
                        break;
                    case 2:
                        contador[1]++;
                        break;
                    case 3:
                        contador[2]++;
                        break;
                    default:
                        continue;
                }
            } while (codigo != 4);

            System.Console.WriteLine("MUITO OBRIGADO");
            System.Console.WriteLine("Alcool: " + contador[0]);
            System.Console.WriteLine("Gasolina: " + contador[1]);
            System.Console.WriteLine("Diesel: " + contador[2]);
        }

    }

}
