namespace Evento.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public int NumberOfTickets { get; set; }
        public int NumberOfTicketsSold { get; set; }
        public string Photo { get; set; }
        public int AssociationId { get; set; }
        public int VenueId { get; set; }

    }
}
