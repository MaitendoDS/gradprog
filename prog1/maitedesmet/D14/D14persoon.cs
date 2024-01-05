namespace D14
{
    internal class D14persoon
    {
        static void Main(string[] args)
        {
            Persoon maite = new Persoon();
            maite.SetNaam("Maïté");

            Persoon piet = new Persoon();
            piet.SetNaam("Piet");

            DateTime dt = new DateTime(2005,12,30);

            maite.SetGeboortedatum(dt);

            maite.SetWoonplaats("thuis");

            Console.WriteLine(maite.GetWoonplaats());

            Console.WriteLine(maite.GetGeboortedatum());
            Console.WriteLine(maite.Leeftijd());




            piet.SetGeboortedatum(dt);

            piet.SetWoonplaats("thuis");

            Console.WriteLine(piet.GetWoonplaats());

            Console.WriteLine(piet.GetGeboortedatum());
            Console.WriteLine(piet.Leeftijd());

            //maite.Geboortedatum = dt;
            //Console.WriteLine(maite.Geboortedatum);

        }     
    }
}