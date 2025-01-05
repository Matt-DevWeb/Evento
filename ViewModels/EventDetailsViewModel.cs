using Evento.Models;

namespace Evento.ViewModels
{
    public class EventDetailsViewModel
    {
        public Event Eventt { get; set; }
        public Association Association { get; set; }
        public Venue Venue { get; set; }    
    }
}
