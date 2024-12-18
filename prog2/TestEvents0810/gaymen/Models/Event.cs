namespace EventsTest.Models
{
    public class Event
    {
        public Event(int id,string name, string date, string location, int maxVisitors, Visitor visitors)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Date = date ?? throw new ArgumentNullException(nameof(date));
            Location = location ?? throw new ArgumentNullException(nameof(location));
            MaxVisitors = maxVisitors;
            Visitors = visitors;
        }

        public Event(string name, string date, string location, int maxVisitors, Visitor visitors)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Date = date ?? throw new ArgumentNullException(nameof(date));
            Location = location ?? throw new ArgumentNullException(nameof(location));
            MaxVisitors = maxVisitors;
            Visitors = visitors;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public int MaxVisitors { get; set; }
        public Visitor Visitors { get; set; }


        }
   




}
