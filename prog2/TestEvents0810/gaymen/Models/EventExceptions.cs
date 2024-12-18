using EventsTest.Models;
namespace EventsTest.Models
{
    public class EventExceptions : Exception
    {
        public EventExceptions(string? message) : base(message)
        {

        }
    }
}
