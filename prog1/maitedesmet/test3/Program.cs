using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace kans1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Haal onderstaande regel uit commentaar als je aan de oplossing van oefening 1
            // werkt en zorg dat de regel voor oefening 2 verderop in commentaar staat
            Oplossing1();

            // Haal onderstaande regel uit commentaar als je aan de oplossing van oefening 2
            // werkt en zorg dat de regel voor oefening 1 hierboven in commentaar staat
            //Oplossing2();
        }

        // 1.1) Schrijf hieronder de gevraagde enumeratie 'DagSoort'

        enum DagSoort { Werkdag, HalveWerkdag, Vrijaf };


        // 1.2) Schrijf hieronder de gevraagde 'GetDagSoort' method

        static DagSoort GetDagSoort(DateTime datum)
        {

            DagSoort werkdag = DagSoort.Werkdag;
            DagSoort halveWerkdag = DagSoort.HalveWerkdag;
            DagSoort vrijaf = DagSoort.Vrijaf;

            DateTime dt = datum;
            int dagNummer = (int)dt.DayOfWeek;



            if (dagNummer == 0 || dagNummer == 6)
            {
                return DagSoort.Vrijaf;
            }
            else if (dagNummer == 3)
            {
                return DagSoort.HalveWerkdag;
            }
            else
            {
                return DagSoort.Werkdag;
            }


        }


        // 1.3) Vul hieronder de code aan voor method 'Oplossing1'

        static void Oplossing1()
        {

            Console.Write("Geef een datum (in ISO-formaat) : ");
            string input = Console.ReadLine();

            // -------------------------
            // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERONDER

            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");

            DateTime datum;
            bool gelukt = DateTime.TryParseExact(input, "yyyy-MM-dd", nlBe, System.Globalization.DateTimeStyles.None, out datum);


            if (!gelukt)
            {
                Console.WriteLine($"\"{input}\" is geen datum in ISO-formaat.");
            }
            else
            {
                if (GetDagSoort(datum) == DagSoort.Vrijaf)
                {
                    Console.WriteLine("Dat is een dag vrijaf!");
                }
                else if (GetDagSoort(datum) == DagSoort.HalveWerkdag)
                {
                    Console.WriteLine("Hoera, een halve dag vrijaf!");
                }
                else
                {
                    Console.WriteLine("Dat is een gewone werkdag");
                }
            }


            // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERBOVEN
            // -------------------------
        }


        // 2.1) Schrijf hieronder de volledige 'Cut' method

        static string[] Cut(string voorbeeld, int aantal)
        {

            bool deelbaar = voorbeeld.Length % aantal == 0;
            string[] gesplitst = new string[aantal];

            if (deelbaar)
            {
                for (int i = 0; i < voorbeeld.Length; i = i + aantal)
                {
                    string stukje = voorbeeld.Substring(i, aantal);
                    gesplitst[i] = gesplitst + stukje;
                }
                return gesplitst;
            }
            else { return gesplitst; }





            // De code van method 'Oplossing2' hieronder is volledig gegeven, als je indient
            // moet hieronder de originele gegeven broncode staan!

            static void Oplossing2()
            {
                string voorbeeld1 = "aaabbbcccdddeee";
                string[] stukjes1 = Cut(voorbeeld1, 3);
                Console.WriteLine(String.Join('|', stukjes1));
                // aaa|bbb|ccc|ddd|eee

                string voorbeeld2 = "abcd";
                string[] stukjes2 = Cut(voorbeeld2, 1);
                Console.WriteLine(String.Join('|', stukjes2));
                // a | b | c | d

                Console.WriteLine(Cut(voorbeeld1, 0) == null);
                // return value is null, want de lengte parameter is 0

                Console.WriteLine(Cut(voorbeeld1, 4) == null);
                // return value is null, want voorbeeld1 is 15 symbolen lang en da's geen veelvoud van 4

                // De output van deze code moet dus exact als volgt zijn :
                // aaa|bbb|ccc|ddd|eee
                // a|b|c|d
                // True
                // True

                // (maar met andere data moet je code natuurlijk ook werken, dus niks hardcoderen!)
            }
        }
    }
}


