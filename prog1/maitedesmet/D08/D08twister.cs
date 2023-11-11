using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08twister
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "rood", "groen", "blauw", "geel" };
            string[] lichaamsdelen = { "linkerhand", "rechterhand", "linkervoet", "rechtervoet" };

            Console.WriteLine("Het spel start over 3 seconden...");
            System.Threading.Thread.Sleep(3000);

            Random rnd = new Random();
            while (true)
            {
                int randomGetal = rnd.Next(0,lichaamsdelen.Length-1);
                string lichaamsdeel = lichaamsdelen[randomGetal];

                randomGetal = rnd.Next(0,kleuren.Length-1);
                string kleur = kleuren[randomGetal];

                Console.WriteLine($"{lichaamsdeel} op {kleur}");

            System.Threading.Thread.Sleep(7000);
            }


        }

        }
    }
