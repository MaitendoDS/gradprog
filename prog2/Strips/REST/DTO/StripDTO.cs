using StripsBL.Models;

namespace REST.DTO
{
    public class StripDTO
    {
        public string Titel { get; set; }
        public int? Nummer { get; set; }

        public Reeks Reeks { get; set; }
        public List<Auteur> Auteurs { get; set; }
        public Uitgeverij Uitgeverij { get; set; }
    }
}
