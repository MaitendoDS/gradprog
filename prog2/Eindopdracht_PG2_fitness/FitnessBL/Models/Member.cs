using System.ComponentModel.DataAnnotations;

namespace FitnessBL.Models
{
    public class Member
    {
        public Member()
        {
        }

        public Member(int id, string firstName, string lastName, string email, string adress, DateTime birthday, List<string?> interests, string memberType)
        {
            MemberID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
            Birthday = birthday;
            Interests = interests;
            MemberType = memberType;
        }

        public Member(int memberID, string firstName, string lastName, string email, string adress, DateTime birthday, List<string?> interests, string memberType, ICollection<RunningSession_Main> runningSessions, ICollection<Reservation> reservations, ICollection<Programma> programmas, ICollection<CyclingSession> cyclingSessions)
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

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime Birthday { get; set; }
        public List<string?> Interests { get; set; }
        public string MemberType { get; set; }

        public ICollection<RunningSession_Main> RunningSessions { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Programma> Programmas { get; set; }
        public ICollection<CyclingSession> CyclingSessions { get; set;}
    }
}
