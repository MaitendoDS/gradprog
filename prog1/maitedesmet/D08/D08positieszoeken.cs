using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08positieszoeken
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

                     
                Console.Write("geef een waarde: ");
                int teZoekenWaarde = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                int getal = a[i];
                if (getal ==  teZoekenWaarde)
                {
                    Console.WriteLine(i);
                }
            }

              
        }
    }
}
