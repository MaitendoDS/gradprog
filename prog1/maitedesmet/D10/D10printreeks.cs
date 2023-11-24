using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10printreeks
    {
        static void Main()
        {
            PrintReeks(10, 15);
            PrintReeks(8, 3);
            PrintReeks(4 , 4);
        }

        static void PrintReeks(int start, int einde)
        {
            if (einde < start)
            {
                PrintReeks(einde, start);
            }
            else
            {
                while (start < einde)
                {
                    Console.WriteLine(start + " > ");
                }
            }
            Console.WriteLine();
        }
    }
}

