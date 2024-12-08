using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class ProgramMembers
    {
        public ProgramMembers()
        {
        }

        public Programma ProgramCode { get; set; }
        public Members MemberID { get; set; }
    }
}
