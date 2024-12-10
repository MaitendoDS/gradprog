using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Member
    {
        public Member()
        {
        }

        public Member(int memberID, string firstName, string lastName, string email, DateOnly birthday, List<string?> interests, string memberType)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            Interests = interests;
            MemberType = memberType;
        }

        public Member(string firstName, string lastName, string email, DateOnly birthday, List<string?> interests, string memberType, ICollection<RunningSession_Main> sessions, ICollection<Reservation> reservations, ICollection<Programma> programmas, ICollection<CyclingSession> cyclingSessions)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            Interests = interests;
            MemberType = memberType;
            Sessions = sessions;
            Reservations = reservations;
            Programmas = programmas;
            CyclingSessions = cyclingSessions;
        }

        public Member(int memberID, string firstName, string lastName, string email, DateOnly birthday, List<string?> interests, string memberType, ICollection<RunningSession_Main> sessions, ICollection<Reservation> reservations, ICollection<Programma> programmas, ICollection<CyclingSession> cyclingSessions)
        {
            MemberID = memberID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            Interests = interests;
            MemberType = memberType;
            Sessions = sessions;
            Reservations = reservations;
            Programmas = programmas;
            CyclingSessions = cyclingSessions;
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
