using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08arrayopvullen
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];

            // opvullen
            for (int i = 0; i < getallen.Length; i++) 
            {
                getallen[i] = i + 101;
            }

            // afdrukken
            for (int index = 0; index < getallen.Length; index++)
            {
                Console.Write(getallen[index] + " ");
            }
        }
    }
}
