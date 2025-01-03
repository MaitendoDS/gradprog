using StripsBL.Models;

namespace REST.DTO
{
    public class StripDTO
    {
      
        public string Titel { get; set; }
        public int? Nummer { get; set; }
        public int ReeksID { get; set; }
        public int UitgeverijID { get; set; }
        public int AuteurID { get; set; }
    }
}
