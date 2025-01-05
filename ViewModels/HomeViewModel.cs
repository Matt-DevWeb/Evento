using Evento.Models;

namespace Evento.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Event Eventt { get; set; }
    }
}
