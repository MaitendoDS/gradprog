using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10bevat
    {
        static void Main(string[] args)
        {

            Console.WriteLine("geef een dier: ");
            string boerderijDier = Console.ReadLine();
         
        

            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            bool gevonden = Bevat(boerderijDieren,boerderijDier);


            Console.WriteLine(Bevat(boerderijDieren, boerderijDier));


        }

        static bool Bevat(string[] woorden, string zoekwoord)
        {
            

            bool gevonden = false;

            foreach (string dier in woorden)
            {
                if (zoekwoord.ToLower() == dier.ToLower())
                {
                    gevonden = true;
                    break;
                }
            }
            return gevonden;


        }
    }
}

