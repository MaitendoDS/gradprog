using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class MemberEF
    {
        public MemberEF()
        {
        }

        public MemberEF(int memberID, string firstName, string lastName, string email, string adress, DateTime birthday, List<string>? interests, string memberType, ICollection<RunningSession_MainEF> runningSessions, ICollection<ReservationEF> reservations, ICollection<ProgrammaEF> programmas, ICollection<CyclingSessionEF> cyclingSessions)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            Birthday = birthday;
            Interests = interests;
            MemberType = memberType;

            RunningSessions = runningSessions;
            Reservations = reservations;
            Programmas = programmas;
            CyclingSessions = cyclingSessions;
        }

        [Key]
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime Birthday { get; set; }
        public List<string>? Interests { get; set; }
        public string MemberType { get; set; }

        public ICollection<RunningSession_MainEF> RunningSessions { get; set; } //nav props
        public ICollection<ReservationEF> Reservations { get; set; }
        public ICollection<ProgrammaEF> Programmas { get; set; }
        public ICollection<CyclingSessionEF> CyclingSessions { get; set;}
    }
}
