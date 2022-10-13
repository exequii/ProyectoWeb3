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
            return View();
        }

        [HttpPost]
        public IActionResult CrearPartido(Partido partido)
        {
            if (!ModelState.IsValid)
                return View(partido);

            _partidoController.Crear(partido);
            return Redirect("/Partido/Predicciones");
        }
        public IActionResult Predicciones()
        {
            return View(_partidoController.Listar());
        }
    }
}
