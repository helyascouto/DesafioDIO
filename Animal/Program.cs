using System;
using System.Text;

class Animal
{
    public static void Main(string[] args)
    {
        String Tipo1 = Console.ReadLine();
        String Tipo2 = Console.ReadLine();
        String Tipo3 = Console.ReadLine();

        if ((Tipo1 == "vertebrado") && (Tipo2 == "mamifero") && (Tipo3 == "onivoro"))
        {
            Console.WriteLine("homem\n");
        }

        if ((Tipo1 == "vertebrado") && (Tipo2 == "mamifero") && (Tipo3 == "herbivoro"))
        {
            Console.WriteLine("vaca\n");
        }

        if ((Tipo1 == "vertebrado") && (Tipo2 == "ave") && (Tipo3 == "carnivoro"))
        {
            Console.WriteLine("aguia\n");
        }

        if ((Tipo1 == "invertebrado") && (Tipo2 == "inseto") && (Tipo3 == "hematofago"))
        {
            Console.WriteLine("pulga\n");
        }

        if ((Tipo1 == "invertebrado") && (Tipo2 == "inseto") && (Tipo3 == "herbivoro"))
        {
            Console.WriteLine("lagarta\n");
        }

        if ((Tipo1 == "invertebrado") && (Tipo2 == "anelideo") && (Tipo3 == "hematofago"))
        {
            Console.WriteLine("sanguessuga\n");
        }

        if ((Tipo1 == "vertebrado") && (Tipo2 == "ave") && (Tipo3 == "onivoro"))
        {
            Console.WriteLine("pomba\n");
        }

        if ((Tipo1 == "invertebrado") && (Tipo2 == "anelideo") && (Tipo3 == "onivoro"))
        {
            Console.WriteLine("minhoca\n");
        }
    }
}