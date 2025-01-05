
namespace Evento.Models
{
    public class EventService : IEventService
    {
        public int AddEvent(string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public Event GetEventByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(int id, string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId)
        {
            throw new NotImplementedException();
        }
    }
}
