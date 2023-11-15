using static System.Net.Mime.MediaTypeNames;

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

        static void Oplossing1()
        {
            // Hieronder is een gans stuk code gegeven, jouw eigen aanvulling moet
            // je verderop toevoegen. De code die hieronder staat mag je niet aanpassen.
            Console.WriteLine("OPLOSSING VAN OEFENING 1");
            Console.WriteLine("------------------------");
            Console.Write("Hoeveel data wil u invoeren : ");

            string aantalAlsTekst = Console.ReadLine();
            int aantal = int.Parse(aantalAlsTekst);

            string[] inputs = new string[aantal];

            for (int i = 0; i < aantal; i++)
            {
                Console.Write($"Geef data #{i + 1} : ");
                inputs[i] = Console.ReadLine();
            }

            string[] teksten = new string[aantal];
            int aantalTeksten = 0;

            int[] getallen = new int[aantal];
            int aantalGetallen = 0;
            // De code hierboven is gegeven, je mag deze code niet aanpassen.
            // -------------------------
            // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERONDER

            //bool isGetal = false;
            //bool isWoord = false;

            //if (aantal != 0)
            //    for (int i = 0; i < aantal; i++)
            //    {

            //        getallen[i] = 0;
            //        isGetal = true;
            //        aantalGetallen++;
            //        Console.WriteLine(getallen);

            //    }
            //else if (aantalAlsTekst != null)

            //{
            //    for (int i = 0; i < aantal; i++)
            //        teksten[i] = inputs[i];
            //    aantalTeksten++;

            //}

            
            for (int i = 0; i < aantal; i++)
            {
                string input = inputs[i];
                if (int.TryParse(input, out int getal))
                {
                    getallen[aantalGetallen] = getal;
                    aantalGetallen++;
                }
                else if (input != "")
                {
                    teksten[aantalTeksten] = input;
                    aantalTeksten++;
                }
            }


            // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERBOVEN
            // -------------------------
            // Hieronder zijn nog een aantal regels code gegeven, die de gegevens
            // op de console plaatsen. Je mag deze code niet aanpassen.
            Console.Write($"{aantalGetallen} getal(len) : ");
            for (int i = 0; i < aantalGetallen; i++)
            {
                Console.Write($"({getallen[i]}) ");
            }
            Console.WriteLine();
            Console.Write($"{aantalTeksten} tekst(en) : ");
            for (int i = 0; i < aantalTeksten; i++)
            {
                Console.Write($"\"{teksten[i]}\" ");
            }
        }

        static void Oplossing2()
        {
            // Onderstaande regels zijn gegeven, je mag deze niet aanpassen.
            Console.WriteLine("OPLOSSING VAN OEFENING 2");
            Console.WriteLine("------------------------");
            Console.Write("Geef een aantal woorden in (gescheiden door spaties) : ");
            string input = Console.ReadLine();

            if (input != "")
            {
                // -------------------------
                // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERONDER
                string[] woorden = input.Split(' ');



                bool isgroterdan = false;
                //int aantal = 0;

                for (int i = 0; i < woorden.Length - 1; i++)
                //foreach (string woord in woorden)
                {

                    if (woorden[i].Length > woorden[i + 1].Length)
                    {
                        isgroterdan = true;
                        //aantal++;
                        break;
                    }

                }

                if (isgroterdan)
                {
                    Console.WriteLine("woorden waren gesorteerd op lengte(kort->lang)");
                }
                else
                {
                    Console.WriteLine("woorden waren helaas niet correct op lengte gesorteerd");
                }

                // JOUW AANDEEL VAN DE CODE SCHRIJF JE HIERBOVEN
                // -------------------------
            }
        }

    }
}


