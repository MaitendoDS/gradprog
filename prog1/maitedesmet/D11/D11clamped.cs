using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11clamped
    {
        static void Main()
        {
            Console.WriteLine("Voorbeeld GetClamped met min=3 en max=6");
            for (int i = 1; i <= 8; i++)
            {
                int clamped = GetClamped(3, i, 6);
                Console.WriteLine($"voor {i} geeft dit {clamped}");
            }
        }
        static int GetClamped(int min, int getal, int max)
        {
            if (min <= getal && getal <= max)
            {
                return getal;
            }
            else if (getal < min)
            {
                return min;
            }
            return max;
        }
    }
}
