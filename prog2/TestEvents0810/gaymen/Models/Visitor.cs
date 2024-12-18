namespace EventsTest.Models
{
    public class Visitor
    {
        public Visitor(string name, string birthday, int id)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Birthday = birthday ?? throw new ArgumentNullException(nameof(birthday));
            Id = id;
        }

        public string Name { get; set; }
        public string Birthday { get; set; }
        public int Id { get; set; }
    }
}
