using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalPrograAvanzada.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Perfil() 
        {
            return View();
        }

        public IActionResult EditarPerfil()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }
    }
}
