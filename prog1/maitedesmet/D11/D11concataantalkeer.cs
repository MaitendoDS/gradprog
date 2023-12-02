using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11concataantalkeer
    {
        static void Main()
        {
            string output = ConcatAantalKeer("*-", 5);
            Console.WriteLine(output);
        }
        static string ConcatAantalKeer(string tekst, int aantal)
        {
            for (int i = 0; i < aantal -1; i++)
            {
                Console.Write(tekst);
            }
            return tekst;
        }
    }
}
