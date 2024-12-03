namespace FitnessDL.Models
{
    public class Members
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateOnly Birthday { get; set; }
        public string Interests { get; set; }
        public string MemberType { get; set; }
    }
}
