using Entidades.Entidades;
using Logica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


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

            if(_usuarioController.ValidateUsuarioRegistrado(usuario) != null) 
            {
                ViewBag.Error = "El usuario ingresado ya existe";
                return View(usuario);
            }

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
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("Email")))
            {
                return Redirect("/Home/Index");
            }

            ViewBag.Email = HttpContext.Session.GetString("Email");
            return View();
            
        }

        [HttpGet]
        public IActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            if (_usuarioController.GetUsuario(usuario) == null)
            {
                ViewBag.Error = "Las credenciales ingresadas no son validas";
                return View(usuario);
            }

            HttpContext.Session.SetString("Email", usuario.Email);
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Email", "");
            return Redirect("/Home/Index");
        }
    }
}
