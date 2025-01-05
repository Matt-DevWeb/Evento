using Microsoft.AspNetCore.Mvc;
using Evento.Models;
using Evento.ViewModels;

namespace TPappMVC.Controllers
{
    public class AssociationController : Controller
    {
        public IActionResult AssociationsList()
        {
            List<Association> associations = Associations.GetAssociations();
            AssociationsListViewModel associationsListViewModel = new AssociationsListViewModel
            {
                Associations = associations
            };
            return View(associationsListViewModel);
        }

        public IActionResult AssociationDetails(int id)
        {
            Association association = Associations.GetAssociations().FirstOrDefault(a => a.Id == id);
            List<Event> events = Events.GetEvents().Where(e => e.AssociationId == id).ToList();

            AssociationDetailsViewModel associationDetailsViewModel = new AssociationDetailsViewModel
            {
                Association = association,
                Events = events
            };

            if (association == null)
            {
                return View("AssociationNotFound");
            }

           

            return View(associationDetailsViewModel);
        }

        [HttpPost]
        public IActionResult AddAssociationForm()
        {
            return View();
        }

        public IActionResult UpdateAssociation(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Association association = dal.GetAllAssociations().Where(a => a.Id == id).FirstOrDefault();
                    if (association != null)
                    {
                        return View(association);
                    }
                    return View("Index");
                }
                
            }
            return View("Index");
        }
    }
}
