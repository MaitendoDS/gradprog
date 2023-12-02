using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11geenscheldwoordenarray
    {
        static void Main()
        {
            Console.Write("Geef een tekst : ");
            string tekst = Console.ReadLine();

            bool isOk = IsAanvaardbaar(tekst);

            if (isOk)
            {
                Console.WriteLine("Tekst is aanvaardbaar");
            }
            else
            {
                Console.WriteLine("Tekst is niet aanvaardbaar");
            }
            
            static bool IsAanvaardbaar(string tekst)
            {

                string[] scheldwoorden = { "kamelenneuker", "kaashoer", "kankernicht", "foefkop", "erwtenteller", "aambeienlikker" };
                               
                bool isOk = true;

                foreach (string scheldwoord in scheldwoorden)
                {
                    if (tekst.Contains(scheldwoord))
                    {
                        isOk = false;
                        break;
                    }
                }
                return isOk;
            }
        }
    }
}
