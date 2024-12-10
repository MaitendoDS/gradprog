namespace Eindopdracht_PG2_fitness.DTO
{
    public class MemberDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime Birthday { get; set; }
        public List<string?> Interests { get; set; }
        public string MemberType { get; set; }

    }


}
