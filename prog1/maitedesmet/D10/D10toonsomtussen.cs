using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10toonsomtussen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat is de min?: ");
            int minimum = int.Parse(Console.ReadLine());

            Console.WriteLine("wat is de max");
            int maximum = int.Parse(Console.ReadLine());

            ToonSomTussen(minimum, maximum);
        }
        static void ToonSomTussen(int minimum, int maximum)
        {
            int som = 0;
            for (int i = minimum; i <= maximum; i++)
            {
                som = som + i;
            }
            Console.WriteLine($"De som is {som}");
        }
    }
}
