using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalPrograAvanzada.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult Equipos()
        {
            return View();
        }

        public IActionResult EquiposForm()
        {
            return View();
        }
    }
}
