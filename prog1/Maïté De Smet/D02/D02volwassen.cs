namespace D02
{
    internal class D02volwassen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoe oud ben je?");
            string ingevoerdeLeeftijd = Console.ReadLine();
            int leeftijd = int.Parse(ingevoerdeLeeftijd);

            if (leeftijd >= 18) {
                Console.WriteLine("Je bent volwassen."); 
            } else { Console.WriteLine("Je bent niet volwassen."); }
            }
        }
    }
