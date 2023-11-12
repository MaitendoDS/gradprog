using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09herkansing
    {
        static void Main(string[] args)
        {
            int[] puntenlijst = { 13, 16, 13, 18, 8, 12, 15, 3, 4, 11, 17, 18 };

            bool gebuisd = false;

            foreach (int i in puntenlijst)
            {

                if (i < 10)
                {
                    gebuisd = true;
                    break;
                }

            }
             if (gebuisd)
            {
                Console.WriteLine("er moet een herkansing worden ingericht");

            } else { Console.WriteLine("iedereen is erdoor!!"); }

        }
    }
}
