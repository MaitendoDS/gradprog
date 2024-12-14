using System.ComponentModel.DataAnnotations;

namespace FitnessBL.Models
{
    public class Programma
    {
        public Programma()
        {
        }

        public Programma(int programCode, string name, string target, DateTime startDate, int maxMembers)
        {
            ProgramCode = programCode;
            Name = name;
            Target = target;
            StartDate = startDate;
            MaxMembers = maxMembers;
        }

        public int ProgramCode { get; set; }
        public string Name { get; set; }
        public string Target { get; set; }
        public DateTime StartDate { get; set; }
        public int MaxMembers { get; set; }
    }
}
