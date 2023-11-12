namespace D09
{
    internal class D09zoekdier
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            Console.WriteLine("geef een dier: ");
            string ingevoerdeDier = Console.ReadLine();

            bool gevonden = false;

            foreach (string dier in boerderijDieren)
            {
                if (ingevoerdeDier.ToLower() == dier.ToLower())
                {
                    gevonden = true;
                    break;
                }
            }

            if (!gevonden)
            {
                Console.WriteLine("het is geen boerderijdier");
            }
            else { Console.WriteLine("het is een boerderijdier"); }

        }
    }
}