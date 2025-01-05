using Evento.Models;
using Evento.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Evento.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Event eventt = Events.GetEvents()
                                 .Where(e => e.StartDate > DateTime.Now)
                                 .OrderBy(e => e.StartDate)
                                 .FirstOrDefault();

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Title = "Bienvenue sur le site de Evento",
                Message = "Le site qui vous permet de gérer vos évènements.",
                Date = DateTime.Now,
                Eventt = eventt
            };
            return View(homeViewModel);
        }
    }
}
