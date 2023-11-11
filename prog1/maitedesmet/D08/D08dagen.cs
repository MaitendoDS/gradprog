using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08dagen
    {
        static void Main(string[] args)
        {
            string[] dagen = { "ma", "di", "woe", "do", "vr", "za", "zon" };

            Console.Write($"({dagen.Length} elementen): ");
            for (int index = 0; index < dagen.Length; index++)
            {
                Console.Write(dagen[index] + " ");
            }
        }
    }
}
