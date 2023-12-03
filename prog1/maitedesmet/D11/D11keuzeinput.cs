using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11keuzeinput
    {
        static void Main()
        {
            string[] keuzes = { "Rood", "Groen", "Blauw" };
            int index = GetKeuze(keuzes);
            string kleur = keuzes[index];
            Console.WriteLine($"U koos {kleur}");
        }
        static int GetKeuze(string[] keuzes)
        {
            string input = Console.ReadLine();
            bool juisteKeuze = int.TryParse(input,out int keuze);

            string keuzesString = string.Join(",", keuzes);
            

            for (int i =0; i < keuzes.Length; i++)
            {
            if (input.ToLower == keuzesString.ToLower && juisteKeuze)
                {

                }

            }
        }
    }
}
