using System;

namespace Quantidade_de_Números_Positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePositivos = 0;
            for (int i = 0; i < 6; i++)
            {
                double valorInformadoPeloUsuario = double.Parse(Console.ReadLine());
                if (valorInformadoPeloUsuario > 0)
                {
                    quantidadePositivos += +1; 
                }
            }
            Console.WriteLine(quantidadePositivos + " valores positivos");
        }
    }
}
