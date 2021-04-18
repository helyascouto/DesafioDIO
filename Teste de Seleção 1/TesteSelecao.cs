using System;

class minhaClasse
{

    static void Main(string[] args)
    {
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //complete a condicional
            if ((B > C && D > A) && (C + D > A + B) && (C > 0 && B > 0) && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            };

        }
    }
}
