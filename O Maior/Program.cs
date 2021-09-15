using System;

namespace O_Maior
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            //complete declarando as variáveis

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;

            int maiorentreABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            int MAIOR = maiorentreABC;

            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
