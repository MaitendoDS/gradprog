using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09getalfrequentie
    {
        static void Main(string[] args)
        {
            int[] aantalKeren = new int[11];
            string input;

            do
            {
                Console.Write("Geef een getal in [0,10] : ");
                input = Console.ReadLine();
                if (input.ToLower() != "stop")
                {
                    int getal = int.Parse(input);
                    // onthou in array dat getal nog een keer voorkwam
                    aantalKeren[getal]++;
                }
            } while (input.ToLower() != "stop");

            // toon  output
            for (int i = 0; i < aantalKeren.Length; i++)
            {
                int getal = i;
                int aantalKeerGetal = aantalKeren[getal];
                if (aantalKeerGetal > 0)
                {
                    // getal kwam minstens 1 keer voor
                    Console.WriteLine($"{getal} kwam {aantalKeerGetal} keer voor");
                }
            }
        }
    }
}
