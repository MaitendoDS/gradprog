using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11kader
    {
        static void Main(string[] args)
        {
            ToonInKader("Hallo");
        }
        static void ToonInKader(string input)
        {
            for (int i = 0; i < input.Length+4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine("* " + input + " *");

            for (int i = 0; i < input.Length+4; i++)
            {
                Console.Write("*");
            }
        }
    }
}
