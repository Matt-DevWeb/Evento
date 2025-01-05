using Microsoft.AspNetCore.Mvc;
using Evento.Models;
using System.Collections.Generic;
using Evento.ViewModels;

namespace TPappMVC.Controllers
{
    public class EventController : Controller
    {
        public IActionResult EventsList()
        {
            List<Event> pastEvents = Events.GetEvents().Where(e => e.StartDate < DateTime.Now).ToList();
            List<Event> futureEvents = Events.GetEvents().Where(e => e.StartDate > DateTime.Now).ToList();

            EventsListViewModel eventsListViewModel = new EventsListViewModel
            {
                PastEvents = pastEvents,
                FutureEvents = futureEvents
            };
                return View(eventsListViewModel);
        }

       

        public IActionResult EventDetails(int id)
        {
            
            Event eventt = Events.GetEvents().FirstOrDefault(e => e.Id == id);
            Association association = Associations.GetAssociations().FirstOrDefault(a => a.Id == eventt.AssociationId);
            Venue venue = Venues.GetVenues().FirstOrDefault(v => v.Id == eventt.VenueId);

            EventDetailsViewModel eventDetailsViewModel = new EventDetailsViewModel
            {
                Eventt = eventt,
                Association = association,
                Venue = venue

            };
            if (eventt == null)
            {
                return View("EventNotFound");
            }
            ViewData["NumberOfTicketsToSold"] = venue.Capacity - eventt.NumberOfTicketsSold;

            return View(eventDetailsViewModel);
        }

        public IActionResult UpdateEvent(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Event eventt = dal.GetEventById(id);
                    if (eventt == null)
                    {
                        return View("EventNotFound");
                    }
                    return View(eventt);
                    
                    
                }
            }
            return View("Error");
        }
    }

}
