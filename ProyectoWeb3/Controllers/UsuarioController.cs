using Entidades;
using Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb3.Controllers
{
    public class UsuarioController : Controller
    {
        public IUsuarioService _usuarioController { get; set; }
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioController = usuarioService;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            _usuarioController.Registrar(usuario);
            return Redirect("/Usuario/Usuarios");
        }

        [HttpGet]
        public IActionResult Usuarios()
        {
            return View(_usuarioController.Listar());
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
