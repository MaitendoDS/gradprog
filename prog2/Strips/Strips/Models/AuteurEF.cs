using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripsDL.Models
{
    public class AuteurEF
    {
        public AuteurEF(int auteurID, string email, string naam)
        {
            AuteurID = auteurID;
            Email = email;
            Naam = naam;
        }

        [Key]
        public int AuteurID { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }

        
        public List<StripEF> Strips { get; set; }


    }
}
