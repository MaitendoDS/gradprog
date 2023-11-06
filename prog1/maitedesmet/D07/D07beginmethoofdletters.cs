using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace D07
{
    internal class D07beginmethoofdletters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef een tekst:");
            string tekst = Console.ReadLine();

                    string restVanTekst = tekst.Substring(5);

            for (int i = 0; i <= tekst.Length - 1; i++)
            {

                char c = tekst[i];
                if (i < 5)
                {
                    c = char.ToUpper(c);
                    Console.Write(c);
                }

            }
                    Console.Write(restVanTekst);
        }
    }
}
