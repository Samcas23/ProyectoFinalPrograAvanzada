using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalPrograAvanzada.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nosotros()
        {
            return View();
        }

    }
}
