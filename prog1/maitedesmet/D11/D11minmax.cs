using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11minmax
    {
        static void Main()
        {
            int[] getallen = { -4, 7, 9, 34, 2, 56, 34, 78 };
            Console.WriteLine(BepaalMinimum(getallen));
            Console.WriteLine(BepaalMaximum(getallen));
        }
        
        static int BepaalMinimum(int[] getallen)
        {
            int minimum = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                if (minimum > getallen[i])
                {
                    minimum = getallen[i];
                }
            }
            return minimum;
        }

        static int BepaalMaximum(int[] getallen)
        {
            int maximum = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                if (maximum < getallen[i])
                {
                    maximum = getallen[i];
                }
            }
            return maximum;
        }
    }
}
