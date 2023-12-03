using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11expand
    {
        static void Main()
        {
            // voorbeeld 1 : een reeks één keer dupliceren
            int[] scores1 = { 2, 3, -5, 6 };
            int[] expanded1 = Expand(1, scores1);

            Console.WriteLine(String.Join(",", expanded1));
            // output is : 2,3,-5,6

            // voorbeeld 2 : een reeks drie keer dupliceren
            int[] scores2 = { 2, 3, -5, 6 };
            int[] expanded2 = Expand(3, scores2);

            Console.WriteLine(String.Join(",", expanded2));
            // de output is : 2,2,2,3,3,3,-5,-5,-5,6,6,6

            // voorbeeld 3 : een reeks nul keer dupliceren
            int[] scores3 = { };
            int[] expanded3 = Expand(0, scores3);

            Console.WriteLine(String.Join(",", expanded3));
            // output is : (een lege regel)
            // (de Expand oproep retourneerde immers een lege array)

            // voorbeeld 4 : een lege reeks 5 keer dupliceren
            int[] scores4 = { };
            int[] expanded4 = Expand(5, scores4);

            Console.WriteLine(String.Join(",", expanded4));
            // output is : (een lege regel)
            // (de Expand oproep retourneerde immers een lege array)
        }
        static int[] Expand(int aantal, int[] getallen)
        {
            // als aantal = 0, retourneer lege array
            if (aantal == 0)
            {
                return new int[0];
            }

            // nieuwe array met juiste lengte
            int[] expandedArray = new int[aantal * getallen.Length];

            // vul nieuwe array op 
            for (int i = 0; i < aantal; i++)
            {
                for (int j = 0; j < getallen.Length; j++)
                {
                    expandedArray[i * getallen.Length + j] = getallen[j];
                }
            }

            return expandedArray;
        }
    }
    }

