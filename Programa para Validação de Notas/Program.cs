using System;

namespace ValidacaoNotas
{
    class Desafio
    {

        static void Main(string[] args)
        {

            double somaDasNotas = 0;
            int contador = 0;
            int escolha = 0;

            do
            {
                double notaEntradaConsole = double.Parse(Console.ReadLine());
                if (notaEntradaConsole < 0 || notaEntradaConsole > 10)
                {
                    Console.WriteLine("nota invalida");
                    notaEntradaConsole = 0;
                }
                else
                {
                    contador++;
                    somaDasNotas += notaEntradaConsole;
                    notaEntradaConsole = 0;
                }



                if (contador == 2)
                {
                    double media = somaDasNotas / 2;
                    Console.WriteLine("media = " + (media).ToString("N2"));
                    Console.WriteLine("");
                    Boolean op = false;
                    do
                    {
                        escolha = 0;
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        escolha = Convert.ToInt32(Console.ReadLine());

                        if (escolha == 1)
                        {
                            contador = 0;
                            somaDasNotas = 0;
                            notaEntradaConsole = 0;
                            op = true;
                        }
                        else if (escolha == 2)
                        {
                            contador = 2;
                            op = true;
                        }
                        else
                        {
                            contador = 0;
                            somaDasNotas = 0;
                            notaEntradaConsole = 0;
                            op = false;
                        }



                    } while (op != true);

                }


            } while (contador < 2);

        }
    }
}