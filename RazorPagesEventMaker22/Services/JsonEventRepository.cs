using Microsoft.Extensions.Logging;
using RazorPagesEventMaker22.Helpers;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Services
{
    public class JsonEventRepository : IEventRepository
    {

        //string JsonFileName = @"C:\Users\EASJ\OneDrive - Zealand Sjællands Erhvervsakademi(1)\Dokumenter\UV\SWC2022E\Chap\prog\RazorPagesEventMaker22\RazorPagesEventMaker22\Data\JsonEvents3.json";
        string JsonFileName = @"Data\JsonEvents3.json";
        public void AddEvent(Event ev)
        {
            List<Event> events = GetAllEvents();
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
            JsonFileWriter.WritetoJson(events, JsonFileName);
        }

        public void DeleteEvent(Event ev)
        {
            Event e = GetEvent(ev.Id);
            List<Event> events = GetAllEvents();
            events.Remove(e);
            JsonFileWriter.WritetoJson(events, JsonFileName);
        }

        public List<Event> FilterEvents(string city)
        {
            List<Event> filteredList = new List<Event>();
            foreach (var ev in GetAllEvents())
            {
                if (ev.City.Contains(city))
                {
                    filteredList.Add(ev);
                }
            }
            return filteredList;
        }

        public List<Event> GetAllEvents()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public Event GetEvent(int id)
        {
            foreach (var ev in GetAllEvents())
            {
                if (ev.Id == id)
                    return ev; 
            }
            return new Event();
        }

        public Event GetEvent(string name)
        {
            foreach (var ev in GetAllEvents())
            {
                if (ev.Name == name)
                    return ev;
            }
            return new Event();
        }

        public void UpdateEvent(Event ev)
        {
            if (ev != null)
            {
                List<Event> events = GetAllEvents(); 
                foreach (var evt in events)
                {
                    if (evt.Id == ev.Id)
                    {
                        evt.Id = ev.Id;
                        evt.Name = ev.Name;
                        evt.Description = ev.Description;
                        evt.City = ev.City;
                        evt.DateTime = ev.DateTime;
                        /*return*/;
                    }
                }
                JsonFileWriter.WritetoJson(events, JsonFileName);
            }

        }

        public List<Event> SearchEventByCode(string code)
        {
            List<Event> filteredList = new List<Event>();
            foreach (Event ev in GetAllEvents())
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
