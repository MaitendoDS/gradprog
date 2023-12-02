using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11reversetext
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            Console.WriteLine(ReverseText(tekst));
        }

        static string ReverseText(string tekst)
        {
            string tekstOmgekeerd = null;

            foreach(char c in tekst)
            {
                tekstOmgekeerd = c + tekstOmgekeerd;
            }


            return tekstOmgekeerd;
        }
    }
}
