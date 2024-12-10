using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class ProgramMember
    {
        public ProgramMember()
        {
        }

        public ProgramMember(Programma programCode, Member memberID)
        {
            ProgramCode = programCode;
            MemberID = memberID;
        }

        public Programma ProgramCode { get; set; }
        public Member MemberID { get; set; }
    }
}
