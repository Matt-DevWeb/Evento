namespace Evento.Models
{
    // IDisposable nettoie l’interface quand plus besoin
    public interface IDal :IDisposable
    {
        public void DeleteCreateDatabase();

        public List<Event> GetAllEvents();

        public int AddEvent(string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId);

        public void UpdateEvent(int id, string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId);

        public void DeleteEvent(int id);

       // public Event GetEventById(int id);

        public Event GetEventByName(string name);
    }
}
