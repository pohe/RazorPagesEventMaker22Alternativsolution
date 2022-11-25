using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    public class FakeEventRepository : IEventRepository
    {
        private List<Event> events { get; }

        public FakeEventRepository()
        {
            events = new List<Event>();
            events.Add(new Event()
            {
                Id = 1,
                Name = "Roskilde Festival",
                Description = " A lot of music",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 10, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 2,
                Name = "CPH Marathon",
                Description = " Many Marathon runners",
                City = "Copenhagen",
                DateTime = new DateTime(2020, 3, 6, 9, 30, 0)
            });
            events.Add(new Event()
            {
                Id = 3,
                Name = "CPH Distorsion",
                Description = " A lot of beers",
                City = "Copenhagen",
                DateTime = new DateTime(2019, 6, 4, 14, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 4,
                Name = "Demo Day",
                Description = "Project Presentation",
                City = "Roskilde",
                DateTime = new DateTime(2020, 6, 9, 9, 0, 0)
            });
            events.Add(new Event()
            {
                Id = 5,
                Name = "VM Badminton",
                Description = "Badminton",
                City = "Århus",
                DateTime = new DateTime(2020, 10, 3, 16, 0, 0)
            });
        }

        public List<Event> GetAllEvents()
        {
            return events.ToList();
        }
        public void AddEvent(Event ev)
        {
            List<int> eventIds = new List<int>();

            foreach (var evt in events)
            {
                eventIds.Add(evt.Id);
            }
            if (eventIds.Count != 0)
            {
                int start = eventIds.Max();
                ev.Id = start + 1;
            }
            else
            {
                ev.Id = 1;
            }
            events.Add(ev);
        }

        public Event GetEvent(int id)
        {
            foreach (var evt in events)
            {
                if (evt.Id == id)
                    return evt;
            }
            return new Event();
        }

        public Event GetEvent(string name)
        {
            foreach (var evt in events)
            {
                if (evt.Name == name)
                    return evt;
            }
            return new Event();
        }

        public void DeleteEvent(Event ev)
        {
            Event e = GetEvent(ev.Id);
            events.Remove(e);
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                foreach (var evt in events)
                {
                    if (evt.Id == ev.Id)
                    {
                        evt.Id = ev.Id;
                        evt.Name = ev.Name;
                        evt.Description = ev.Description;
                        evt.City = ev.City;
                        evt.DateTime = ev.DateTime;
                        return;
                    }
                }
            }

        }

        public List<Event> FilterEvents(string city)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var ev in events)
            {
                if (ev.City.Contains(city))
                {
                    filteredList.Add(ev);
                }
            }
            return filteredList;

        }

        public List<Event> SearchEventByCode(string code)
        {
            List<Event> filteredList = new List<Event>();
            foreach (Event ev in events)
            {
                if (ev.CountryCode == code)
                {
                    filteredList.Add(ev);
                }
            }
            return filteredList;
        }
    }
}
