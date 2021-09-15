using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedro_Bento_e_o_Mundo_de_OZ
{
    class Program
    {
     //A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento.
     //Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

       static void Main(string[] args)
        {
            int tipoJoias, totalString = 0;
            bool op = true;
            string joias;

            do
	        {
                joias = Console.ReadLine();

                if (totalString <= 106)
	            {
                    totalString += joias.Count();
                    
                    if (joias == "(")
                    {

                    }
                    else if (joias == "(")
                    {

                    }
	{

	}
	{

	}


                    
	            }
                else
                {
                    Console.WriteLine("A string excedeu os 106 caracteres");
                    op = false;
                }
                
	        }  while (op == true)


              Console.WriteLine(tipoJoias);
        }
    }
}
