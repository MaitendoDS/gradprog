using StripsBL.Models;
using StripsDL;
using StripsDL.Migrations;
using StripsDL.Models;
using System.IO;

namespace Strips
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StripsContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Console.WriteLine("Database is opnieuw aangemaakt");
            }



            using (var context = new StripsContext())
            {
                var auteurs = new Dictionary<string, AuteurEF>();
                var reeksen = new Dictionary<string, ReeksEF>();
                var uitgeverijen = new Dictionary<string, UitgeverijEF>();
                var strips = new HashSet<StripEF>();


                using (var rd = new StreamReader(@"C:\Users\maite\gradprog\prog2\Strips\stripsData.txt"))
                {
                    rd.ReadLine();
                    string line;

                    while ((line = rd.ReadLine()) != null)
                    {
                        string[] data = line.Split(";");

                        int? reeksNr = null;

                        if (int.TryParse(data[0].Trim(), out int geparsedReeksNr))
                        {
                            reeksNr = geparsedReeksNr;
                        }
                        string titel = data[1].Trim();
                        string uitgeverij = data[2].Trim();
                        string reeks = data[3].Trim();
                        string[] auteursNamen = data[4]
                            .Split("|")
                            .Select(x => x.Replace("\"", "").Trim())
                            .ToArray();


                        reeksen.TryAdd(reeks, new ReeksEF(reeks));
                        uitgeverijen.TryAdd(uitgeverij, new UitgeverijEF(uitgeverij));

                        StripEF strip = new StripEF
                        {
                            Titel = titel,
                            Nummer = reeksNr,
                            Reeks = reeksen[reeks],

                            Uitgeverij = uitgeverijen[uitgeverij],

                        };


                        
                        List<AuteurEF> auteurList = new List<AuteurEF>();

                        foreach (var a in auteursNamen)
                        {

                            auteurs.TryAdd(a, new AuteurEF(a));
                            auteurList.Add(auteurs[a]);


                        }

                        strip.Auteurs = auteurList;
                        strips.Add(strip);
                    }
                }
                context.Strip.AddRange(strips);
                context.SaveChanges();


            }


            //    rd.ReadLine();
            //    while (!rd.EndOfStream)
            //    {
            //        var splits = rd.ReadLine().Split(';');
            //        nrs.Add(splits[0]);
            //        titels.Add(splits[1]);
            //        uitgeverijen.Add(splits[2]);
            //        reeksnamen.Add(splits[3]);
            //        auteurs.Add(splits[4]);

            //    }
            //}

            //Console.WriteLine("nrs:");
            //Console.WriteLine(nrs[3]);

            //Console.WriteLine("titels:");
            //Console.WriteLine(titels[3]);

            //Console.WriteLine("uitgeverijen:");
            //Console.WriteLine(uitgeverijen[3]);

            //Console.WriteLine("reeksnamen:");
            //Console.WriteLine(reeksnamen[3]);

            //Console.WriteLine("auteurs:");
            //Console.WriteLine(auteurs[3]);

        }
    }
}
