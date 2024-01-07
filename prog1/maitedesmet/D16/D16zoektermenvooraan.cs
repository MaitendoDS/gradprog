using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16zoektermenvooraan
    {
        static void Main(string[] args)
        {

            List<string> zoekhistoriek = new List<string> { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };
            
            
                zoekhistoriek.Reverse();
            do
            {
                Console.WriteLine(String.Join(":", zoekhistoriek));
                zoekhistoriek.Reverse();



                Console.Write("Nieuwe zoekterm: ");
                string input = Console.ReadLine();
                zoekhistoriek.Add(input);
                zoekhistoriek.Reverse();


                zoekhistoriek.RemoveAt(zoekhistoriek.Count-1);

                
                
                Console.WriteLine();

            } while (true);
        }
    }
}
