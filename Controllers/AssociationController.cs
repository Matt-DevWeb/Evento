using Microsoft.AspNetCore.Mvc;
using Evento.Models;

namespace TPappMVC.Controllers
{
    public class AssociationController : Controller
    {
        public IActionResult AssociationsList()
        {
            ViewData["Associations"] = Associations.GetAssociations();
            return View();
        }

        public IActionResult AssociationDetails(int id)
        {
            Association myAssociation = Associations.GetAssociations().FirstOrDefault(a => a.Id == id);
            if (myAssociation == null)
            {
                return View("AssociationNotFound");
            }
            ViewData["Name"] = myAssociation.Name;
            ViewData["Description"] = myAssociation.Description;
            ViewData["Siret"] = myAssociation.Siret;

            //Liste des évènements de l’association
            Event myEvent = Events.GetEvents().FirstOrDefault(e => e.AssociationId == id);

            List<Event> myEvents = Events.GetEvents().Where(e => e.AssociationId == id).ToList();
            ViewData["Events"] = myEvents;

            return View();
        }
    }
}
