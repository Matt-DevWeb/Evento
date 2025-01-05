using Evento.Models;

namespace Evento.ViewModels
{
    public class EventsListViewModel
    {
        public List<Event> PastEvents { get; set; }
        public List<Event> FutureEvents { get; set; }
    }
}
