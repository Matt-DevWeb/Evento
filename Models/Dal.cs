﻿

using System.Xml.Linq;

namespace Evento.Models
{
    public class Dal : IDal
    {
        private BddContext _bddContext;

        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

       /* public void InitializeDatabase()
        {
           AddEvent("Soirée Halloween", "Soirée déguisée", new DateTime(2021, 10, 31), new DateTime(2021, 10, 31), 10, 100, "halloween.jpg", 1, 2);
           AddEvent("Concert de Rock", "Un concert de rock incroyable.", new DateTime(2023, 11, 1), new DateTime(2023, 11, 1), 50.0f, 200, "rock_concert.jpg", 1, 3);

           UpdateEvent(1, "Soirée Halloween", "Soirée déguisée de ouf", new DateTime(2021, 10, 31), new DateTime(2021, 10, 31), 10, 100, "halloween.jpg", 1, 2);
        }*/

        public void Dispose()
        {
            _bddContext.Dispose(); // permet de se déconnecter de la base de données
        }

        public List<Event> GetAllEvents()
        {
            return _bddContext.Events.ToList();
        }

        public int AddEvent(string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId)
        {
            Event eventt = new Event() { Name = name, Description = description, StartDate = startDate, EndDate = endDate, Price = price, NumberOfTickets = numberOfTickets, Photo = photo, AssociationId = associationId, VenueId = venueId };
            _bddContext.Events.Add(eventt);
            _bddContext.SaveChanges();
            return eventt.Id;
        }

        public void UpdateEvent(int id, string name, string description, DateTime startDate, DateTime endDate, float price, int numberOfTickets, string photo, int associationId, int venueId)
        {
            Event eventt = _bddContext.Events.Find(id);

            if (eventt != null)
            {
                eventt.Name = name;
                eventt.Description = description;
                eventt.StartDate = startDate;
                eventt.EndDate = endDate;
                eventt.Price = price;
                eventt.NumberOfTickets = numberOfTickets;
                eventt.Photo = photo;
                eventt.AssociationId = associationId;
                eventt.VenueId = venueId;
                _bddContext.SaveChanges();
            }
        }

        public void DeleteEvent(int id)
        {
            Event eventt = _bddContext.Events.Find(id);
           
            if (eventt != null)
            {
                _bddContext.Events.Remove(eventt);
                _bddContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Event not found");
            }

        }

        public Event GetEventById(int id)
        {
            // return _bddContext.Events.Find(id);
            return GetAllEvents().FirstOrDefault(e => (e.Id == id));
        }

        public Event GetEventByName(string name)
        {
            return GetAllEvents().FirstOrDefault(e => (e.Name == name));
        }

        public List<Association> GetAllAssociations()
        {
            return _bddContext.Associations.ToList();
        }
    }
}
