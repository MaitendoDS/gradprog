using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08positieszoekenmooier
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };


            Console.Write("geef een waarde: ");
            int teZoekenWaarde = int.Parse(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                int getal = a[i];
                if (getal == teZoekenWaarde)
                {
                    Console.WriteLine($"waarde {teZoekenWaarde} is gevonden op positie(s) {getal}.");

                }
                else { Console.WriteLine("waarde niet gevonden"); }

                //int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

                //Console.Write("Geef een getal : ");
                //string zoekGetalAlsTekst = Console.ReadLine();
                //int zoekGetal = int.Parse(zoekGetalAlsTekst);

                //string positiesTekst = "";
                //for (int i = 0; i < a.Length; i++)
                //{
                //    int getal = a[i];
                //    if (getal == zoekGetal)
                //    {
                //        positiesTekst += i + " ";
                //    }
                //}

                //if (positiesTekst != "")
                //{
                //    Console.WriteLine($"waarde {zoekGetal} gevonden op positie(s) {positiesTekst}");
                //}
                //else
                //{
                //    Console.WriteLine("waarde niet gevonden");
                }
            }
        }
    }
}
