using System;
using System.Collections.Generic;
using static Test4.Program;

namespace Test4
{
    class Program
    {

        // --- BEGIN OEFENING 1 TODO
        // Wijzig onderstaande class 'Movie' aan zoals beschreven in de opgave.
        public class Movie
        {


            public Movie(string title, int year, int duration)
            {
                Title = title;
                Year = year;
                Duration = duration;
            }

            public string Title { get; }

            public int Year { get; set; }


            public int Duration { get; set; }


            public override string ToString()
            {
                return $"{Year} {Title} ({Duration} min)";
            }
        }
        // --- EINDE OEFENING 1 TODO


        static void Main()
        {
            List<Movie> movies = new List<Movie>() {
                new Movie("Titanic", 1997, 194),
                new Movie("The Big Lebowski", 1998, 117),
                new Movie("The Matrix", 1999, 136),
                new Movie("Fight Club", 1999, 139),
                new Movie("The Truman Show", 1998, 103),
                new Movie("The Game", 1997, 129),
                new Movie("Saving Private Ryan", 1998, 169),
                new Movie("Office Space", 1999, 89),
                new Movie("Boogie Nights", 1997, 155),
                new Movie("Galaxy Quest", 1999, 102)
            };

            // --- BEGIN OEFENING 2 TODO 1
            // Voor oefening 2 zul je onderstaande regel uit commentaar moeten halen
            // en daarna de 'CreateYearToShortestMovie' method schrijven (zie verderop)

            Dictionary<int, Movie> yearToShortestMovie = CreateYearToShortestMovie(movies);

            // --- EINDE OEFENING 2 TODO 1


            // --- BEGIN OEFENING 2 TODO 2
            // Toon hieronder de output van de kortste films per jaartal, zoals beschreven in de opgave


            for (int i = 0; i < yearToShortestMovie.Count; i++)
            {
               // Console.WriteLine($"Kortste in {movies.Year} : {movies.Name} ({movies.Duration}min)");
                Console.WriteLine($"{yearToShortestMovie[i]}");


            }



            // --- EINDE OEFENING 2 TODO 2


            Console.WriteLine();
            Console.WriteLine("Ongesorteerd :");
            Console.WriteLine(String.Join("\n", movies));

            // --- BEGIN OEFENING 3 TODO 1
            // Schrijf hieronder de code om de 'movies' lijst te sorteren met behulp van
            // een 'MovieComparerByYearThenTitle' object





            // --- EINDE OEFENING 3 TODO 1

            Console.WriteLine();
            Console.WriteLine("Gesorteerd :");
            Console.WriteLine(String.Join("\n", movies));

        }

        // --- BEGIN OEFENING 2 TODO 1
        // Schrijf hieronder de CreateYearToShortestMovie method zoals beschreven in de opgave

        static Dictionary<int, Movie> CreateYearToShortestMovie(List<Movie> movies)
        {


            Dictionary<int, int> _yearToShortestMovie = new Dictionary<int, int>();

            _yearToShortestMovie.Add(movies.Year, movies.Duration);



            return _yearToShortestMovie;
        }


        // --- EINDE OEFENING 2 TODO 1


        // --- BEGIN OEFENING 3 TODO 2
        // Vul de MovieComparerByYear class aan, zoals beschreven in de opgave
        class MovieComparerByYearThenTitle : IComparer<Movie>
        {

            public int CompareYear(Movie x, Movie y)
            {



                return x.Year.CompareTo(y.Year);
            }

        }

        // --- EINDE OEFENING 3 TODO 2
    }
}
