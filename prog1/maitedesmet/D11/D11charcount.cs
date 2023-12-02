using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11charcount
    {
        static void Main(string[] args)
        {
            int aantal = GetCharCount("This is a local shop, for local people; there's nothing for you here..", 'o');

            Console.WriteLine(aantal);
        }
        static int GetCharCount(string tekst, char zoektekst)
        {
            int aantalKeer = 0;
            string tekstKleineLetters = tekst.ToLower();
            char zoektekstKleineLetters = char.ToLower(zoektekst);
           
            foreach (char c in tekstKleineLetters)
            {
                if (c == zoektekstKleineLetters)
                {
                    aantalKeer++;
                }
            }
            return aantalKeer;
        }
    }
}

