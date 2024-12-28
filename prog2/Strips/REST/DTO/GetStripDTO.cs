using StripsBL.Models;

namespace REST.DTO
{
    public class GetStripDTO
    {
        public string Url { get; set; }
        public string Titel { get; set; }
        public int? Nummer { get; set; }

        public string Reeks { get; set; }
        public string ReeksUrl { get; set; }

        public string Uitgeverij { get; set; }

        public string UitgeverijUrl { get; set; }
        public List<AuteurStripDTO> AuteurStripDTO { get; set; }

    }
}
