using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07achterstevoren
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst : ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                Console.Write(c);
            }
        }
    }
}
