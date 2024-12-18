using EventsTest.Models;
namespace EventsTest.Models
{
    public interface IEventRepository
    {
        void AddEvent(Event @event);
        //void AddVisitor(Visitor visitor);
        Event GetEvent(int id);
        IEnumerable<Event> GetAll();
        IEnumerable<Event> GetAll(string name);
        IEnumerable<Event> GetAllByDate(string date);
        IEnumerable<Event> GetAllByLocation(string location);
        IEnumerable<Visitor> GetAllVisitors();
        IEnumerable<Visitor> GetAllVisitors(int id);

        void RemoveEvent(Event @event);
        void UpdateEvent(Event @event);
        

    }
}
