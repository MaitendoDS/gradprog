using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07bevatleesteken
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een tekst:");
            string tekst = Console.ReadLine();
            char c = tekst[tekst.Length-1];

            bool punctuatie = Char.IsPunctuation(c);

            if (punctuatie)
            {
                Console.WriteLine("er staat een leesteken in");
            }
            else {
                Console.WriteLine("Er staat geen leesteken");
            }

      

           
        }
    }
}
