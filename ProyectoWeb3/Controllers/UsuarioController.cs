using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb3.Controllers
{
    public class UsuarioController : Controller
    {

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PerfilUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return View();
        }
    }
}
