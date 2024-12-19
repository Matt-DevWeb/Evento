using Microsoft.AspNetCore.Mvc;
using Evento.Models;

namespace TPappMVC.Controllers
{
    public class EventController : Controller
    {
        public IActionResult EventsList()
        {
            ViewData["PastEvents"] = Events.GetEvents().Where(e => e.StartDate < DateTime.Now).ToList();
            ViewData["FutureEvents"] = Events.GetEvents().Where(e => e.StartDate > DateTime.Now).ToList();
            return View();
        }

       

        public IActionResult EventDetails(int id)
        {
            Event myEvent = Events.GetEvents().FirstOrDefault(e => e.Id == id);
            Association myAssociation = Associations.GetAssociations().FirstOrDefault(a => a.Id == myEvent.AssociationId);
            Venue myVenue = Venues.GetVenues().FirstOrDefault(v => v.Id == myEvent.VenueId);
            if (myEvent == null)
            {
                return View("EventNotFound");
            }
            ViewData["Name"] = myEvent.Name;
            ViewData["Description"] = myEvent.Description;
            ViewData["StartDate"] = myEvent.StartDate;
            ViewData["EndDate"] = myEvent.EndDate;
            ViewData["Price"] = myEvent.Price;
            ViewData["Capacity"] = myVenue.Capacity;
            ViewData["NumberOfTicketsToSold"] = myVenue.Capacity - myEvent.NumberOfTicketsSold;
            ViewData["Photo"] = myEvent.Photo;
            ViewData["AssociationId"] = myEvent.AssociationId;
            ViewData["AssociationName"] = myAssociation.Name;
            ViewData["VenueName"] = myVenue.Name;
            ViewData["VenueStreetNumber"] = myVenue.StreetNumber;
            ViewData["VenueStreetName"] = myVenue.StreetName;
            ViewData["VenueCity"] = myVenue.City;
            ViewData["VenueZipCode"] = myVenue.ZipCode;

            return View();
        }
    }

}
