using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07karakterperpositie
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst : ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                Console.WriteLine($"{i,2:d} = {c}");
            }
        }
    }
}
