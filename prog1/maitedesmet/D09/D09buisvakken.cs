using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09buisvakken
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };

            int index = 0;
            bool onvoldoende = false;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] < 50)
                {
                    onvoldoende = true;

                    Console.Write(" " + vakken[i] + "= " + scores[i]);
                }


            }

        }
    }
}
