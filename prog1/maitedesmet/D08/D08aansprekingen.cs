using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08aansprekingen
    {
        static void Main(string[] args)
        {
            string[] aansprekingen = { "Jan", "Piet", "Pol" };

            for (int index = 0; index < aansprekingen.Length; index++)
            {
                aansprekingen[index] = "Dag " + aansprekingen[index];
            }

            foreach (string aanspreking in aansprekingen)
            {
                Console.WriteLine(aanspreking);
            }
        }
    }
}
