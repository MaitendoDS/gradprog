namespace D15
{
    internal class D15persoon
    {
        static void Main(string[] args)
        {
            Persoon maite = new Persoon();

            DateTime dt = new DateTime(2005,12,30);

            maite.Naam = "Maïté";
            maite.Woonplaats = "thuis";
            maite.Geboortedatum = dt;

            Console.WriteLine(maite.Naam);
            Console.WriteLine(maite.Leeftijd());
            Console.WriteLine(maite.Woonplaats);

        }
    }
}