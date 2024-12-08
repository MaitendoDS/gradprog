using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class ProgramMember
    {
        public ProgramMember()
        {
        }

        public Programma ProgramCode { get; set; }
        public Member MemberID { get; set; }
    }
}
