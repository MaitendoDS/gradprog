using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11palindroom
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            Console.WriteLine(IsPalindroom(tekst));
        }
        static bool IsPalindroom(string tekst)
        {
            if (string.IsNullOrEmpty(tekst))
            {
                return false;
            }

            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != tekst[tekst.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
