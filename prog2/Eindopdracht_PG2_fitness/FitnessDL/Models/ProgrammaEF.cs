using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class ProgrammaEF
    {
        public ProgrammaEF()
        {
        }

        public ProgrammaEF(int programCode, string name, string target, DateTime startDate, int maxMembers)
        {
            ProgramCode = programCode;
            Name = name;
            Target = target;
            StartDate = startDate;
            MaxMembers = maxMembers;
        }

        [Key]
        public int ProgramCode { get; set; }
        public string Name { get; set; }
        public string Target { get; set; }
        public DateTime StartDate { get; set; }
        public int MaxMembers { get; set; }

        public ICollection<MemberEF> Members { get; set; }
    }
}
