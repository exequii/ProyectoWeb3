using Entidades.Entidades;
using Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoWeb3.Controllers
{
    public class PartidoController : Controller
    {
        public IPartidoService _partidoController { get; set; }
        public PartidoController(IPartidoService partidoService)
        {
            _partidoController = partidoService;
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
            _partidoController.Crear(partido);
            return Redirect("/Partido/Predicciones");
        }
        public IActionResult Predicciones()
        {
            ViewBag.SeleccionesClasificadas = _partidoController.ObtenerSeleccionesClasificadas();
            return View(_partidoController.Listar());
        }
    }
}
