using Evento.Models;

namespace Evento.ViewModels
{
    public class AssociationDetailsViewModel
    {
        public Association Association { get; set; }
        public List<Event> Events { get; set; }
    }
}
