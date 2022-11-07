using Entidades.Entidades;
using Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb3.Controllers
{
    public class PartidoController : Controller
    {
        public IPartidoService _partidoController { get; set; }
        public IUsuarioService _usuarioService { get; set; }
        public PartidoController(IPartidoService partidoService, IUsuarioService usuarioService)
        {
            _partidoController = partidoService;
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult CrearPartido()
        {
            ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
            return View();
        }

        [HttpPost]
        public IActionResult CrearPartido(Partido partido)
        {
            if(partido.IdSeleccion1 == partido.IdSeleccion2)
            {
                ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
                ViewBag.Error = "Las selecciones ingresadas no pueden enfrentarse ya que son la misma";
                return View(partido);
            }
            Usuario usuario = _usuarioService.GetUsuarioPorEmail(HttpContext.Session.GetString("Email"));

            if(usuario==null)
            {
                _partidoController.Crear(partido);
                return Redirect("/Partido/Predicciones");
            }
            _partidoController.Crear(partido,usuario);
            return Redirect("/Partido/Predicciones");
        }

        /*
        public IActionResult Predicciones()
        {
            ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
            return View(_partidoController.Listar());
        }
        */

        public IActionResult Predicciones(int id)
        {
            Usuario usuario = _usuarioService.GetUsuarioPorEmail(HttpContext.Session.GetString("Email"));

            if (id == 2 & usuario!=null) 
            {
                
                ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
                return View(_partidoController.Filtrar(usuario));
            }
            if (id == 2 & usuario == null ) {
                TempData["error"] = "No se inició sesión";
                ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
                return View(_partidoController.Listar());
            }
            ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
            return View(_partidoController.Listar());
        }

    }
}
