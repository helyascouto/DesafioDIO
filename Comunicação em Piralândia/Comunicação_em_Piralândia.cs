using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunicação_em_Piralândia
{
    class Comunicação_em_Piralândia
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();

            Array.Reverse(arr);
            string v = new string(arr);

            Console.WriteLine(v);
        }
    }
}
