using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalPrograAvanzada.Controllers
{
    public class CanchasController : Controller
    {
        public IActionResult Canchas()
        {
            return View();
        }

       public IActionResult CanchasForm() 
        { 
            return View();  
        }
    }
}
