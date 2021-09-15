using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.IO;


namespace Trigo_no_Tabuleiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qtdTeste; i++)
            {
                int qtdCasas = int.Parse(Console.ReadLine());
                BigInteger kg = (BigInteger) Math.Pow(2, qtdCasas) / (12*1000);
                Console.WriteLine("{0} kg", kg.ToString("0"));
            }
            
        }

    }
}


