using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16zoektermenachteraan
    {
        static void Main(string[] args)
        {
            
            List<string>zoekhistoriek = new List<string> { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };
            

            do
            {
                Console.WriteLine(String.Join(":", zoekhistoriek));

                Console.Write("Nieuwe zoekterm: ");
                string input = Console.ReadLine();

    
                for (int i = 0; i < zoekhistoriek.Count - 1; i++)
                {
                    zoekhistoriek[i] = zoekhistoriek[i + 1];
                }
                // nieuwe zoekterm op het einde toevoegen
                zoekhistoriek[zoekhistoriek.Count - 1] = input;

                Console.WriteLine();
            } while (true);
        }
    }
}
