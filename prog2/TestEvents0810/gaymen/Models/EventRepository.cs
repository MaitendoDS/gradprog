using EventsTest.Models;
namespace EventsTest.Models
{
    public class EventRepository : IEventRepository
    {
        private Dictionary<int, Event> data = new Dictionary<int, Event>();
        private Dictionary<int, Visitor> dataV = new Dictionary<int, Visitor>();

        public EventRepository()
        {            
            data.Add(1, new Event(1,"ASP.NET Boot", "2022 - 10 - 24T00:00:00", "Schoonmeersen Lokaal 1.0012", 20, null));
            data.Add(2, new Event(2,"Bijscholing async", "2022 - 11 - 14T00:00:00", "Mercator", 10, null));
            data.Add(3, new Event(3,"MongoDB", "2022 - 12 - 01T00:00:00", "Mercator", 4, null));

            dataV.Add(1, new Visitor("John", "1975-03-12T00:00:00", 1));
            dataV.Add(2, new Visitor("Jane", "1995-07-18T00:00:00", 2));
            dataV.Add(3, new Visitor("David", "2001-04-02T00:00:00", 3));
            dataV.Add(4, new Visitor("Chris", "1999-09-12T00:00:00", 4));
        }

        
        public IEnumerable<Visitor> GetAllVisitors()
        {
            return dataV.Values;
        }

        public IEnumerable<Visitor> GetAllVisitors(int id)
        {
            return dataV.Values.Where(m => m.Id == id);
        }

        //public void AddVisitor(Visitor visitor)
        //{
        //    if (!data.ContainsKey(visitor.Id))
        //    {
        //        throw new EventExceptions("Visitor doesn't exist");
        //    }
        //    else
        //    {
        //        data.Add(data.Count + 1, visitor);
        //    }
        //}

        public IEnumerable<Event> GetAll()
        {
            return data.Values;
        }

        public IEnumerable<Event> GetAll(string name)
        {
            return data.Values.Where(m => m.Name == name);
        }

        public IEnumerable<Event> GetAllByDate(string date)
        {
            return data.Values.Where(m => m.Date == date);
        }
        public IEnumerable<Event> GetAllByLocation(string location)
        {
            return data.Values.Where(m => m.Location == location);
        }

        public void AddEvent(Event @event)
        {
            if (!data.ContainsKey(@event.Id))
            {
                throw new EventExceptions("Event doesn't exist");
            }
            else
            {
                data.Add(data.Count + 1, @event);
            }
        }

        public Event GetEvent(int id)
        {
            if (!data.ContainsKey(id))
            {
                throw new EventExceptions("Event doesn't exist");
            }
            else
            {
                return data[id];
            }
        }

        public void UpdateEvent(Event @event)
        {
            if (!data.ContainsKey(@event.Id))
            {
                throw new EventExceptions("Event doesn't exist");
            }
            else
            {
                data[@event.Id] = @event;
            }
        }

        public void RemoveEvent(Event @event)
        {
            if (!data.ContainsKey(@event.Id))
            {
                throw new EventExceptions("Event doesn't exist");
            }
            else
            {
                data.Remove(@event.Id);
            }

        }

    }
}
