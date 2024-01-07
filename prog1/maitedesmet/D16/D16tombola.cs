using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D16
{
    internal class D16tombola
    {
        static void Main(string[] args)
        {
            List<int> randoms = new List<int>();
            bool gelukt = false;
            int getal = 0;
            List<int> getallen = new List<int>();
            List<int> geraden = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();


                randoms.Add(rnd.Next(1000, 9999));
            }
            string input = "poes";

            while (true)
            {

                Console.WriteLine("geef een nummer: ");
                input = Console.ReadLine();
                gelukt = int.TryParse(input, out getal);

                if (input.Trim() == "")
                {
                    break;
                }
                if (!gelukt)
                {
                    Console.WriteLine("ongeldige input");
                }
                else
                {
                    getallen.Add(getal);
                }
            }

            for (int i = 0; i < getallen.Count; i++)
            {

                if (randoms.Contains(getallen[i]))
                {
                    geraden.Add(getallen[i]);
                }

            }
            if (geraden.Count != 0)
            {

                Console.Write($"Uw winnende nummers zijn: ");

                for (int i = 0; i < geraden.Count; i++)
                {
                    Console.Write(geraden[i] + " ");

                }
            }

                if (geraden.Count != 5)
                {
                    Console.WriteLine();
                    Console.Write("De winnende nummers  die je neit geraden hebt waren ");

                    for (int i = 0; i < randoms.Count; i++)
                    {
                        if (!geraden.Contains(randoms[i]))
                        {
                            Console.Write(randoms[i] + " ");

                        }
                    }
                }
            
        }
    }
}
