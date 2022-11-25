using RazorPagesEventMaker22.Models;

namespace RazorPagesEventMaker22.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEvent(int id);

        Event GetEvent(string name);
        void AddEvent(Event ev);
        void DeleteEvent(Event ev);
        void UpdateEvent(Event ev);
        List<Event> FilterEvents(string city);
        List<Event> SearchEventByCode(string code);
    }
}
