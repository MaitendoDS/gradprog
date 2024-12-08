using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Member
    {
        public Member()
        {
        }

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateOnly Birthday { get; set; }
        public List<string?> Interests { get; set; }
        public string MemberType { get; set; }

        public ICollection<RunningSession_Main> Sessions { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Programma> Programmas { get; set; }
        public ICollection<CyclingSession> CyclingSessions { get; set;}
    }
}
