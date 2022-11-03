using Entidades.Entidades;
using Logica.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nancy.Json;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace ProyectoWeb3.Controllers
{
    public class PartidoController : Controller
    {
        public IPartidoService _partidoService { get; set; }
        public PartidoController(IPartidoService partidoService)
        {
            _partidoService = partidoService;
        }

        [HttpGet]
        public IActionResult CrearPartido()
        {
            ViewBag.SeleccionesClasificadas = _partidoService.ObtenerSeleccionesClasificadas();
            return View();
        }

        [HttpPost]
        public IActionResult CrearPartido(Partido partido)
        {
            if(partido.IdSeleccion1 == partido.IdSeleccion2)
            {
                ViewBag.SeleccionesClasificadas = _partidoService.ObtenerSeleccionesClasificadas();
                ViewBag.Error = "Las selecciones ingresadas no pueden enfrentarse ya que son la misma";
                return View(partido);
            }
            _partidoService.Crear(partido);
            return Redirect("/Partido/Predicciones");
        }
        public IActionResult Predicciones()
        {
            ViewBag.SeleccionesClasificadas = _partidoService.ObtenerSeleccionesClasificadas();
            return View(_partidoService.Listar());
        }



        public JsonResult SeleccionesClasificadas()
        {


            List<Seleccion> selecciones = _partidoService.ObtenerSeleccionesClasificadas();


                 string seleccionBuscadaJson = System.Text.Json.JsonSerializer.Serialize(selecciones);

            return Json(seleccionBuscadaJson);
        }


        [HttpGet]
        [Route("partido/seleccion/{seleccion1}")]
        public JsonResult Seleccion(string seleccion1)
        {
            
            Seleccion seleccionBuscada = _partidoService.ObtenerSeleccionPorNombre(seleccion1);
            //    JavaScriptSerializer js = new JavaScriptSerializer();


            //  Class1 seleccion= new Class1(seleccionBuscada.Seleccion1, seleccionBuscada.Confederacion);
            //var options = new JsonSerializerOptions { WriteIndented = true };
          //  Class1 seleccion = new Class1("asdd","nono");
            string seleccionBuscadaJson = JsonSerializer.Serialize(seleccionBuscada);
           // string seleccionJson = JsonConvert.SerializeObject(seleccionBuscada);

                //string seleccionBuscadaJson2 = js.Serialize(seleccionBuscada);

                //Console.WriteLine(seleccionBuscadaJson);
                
                return Json(seleccionBuscadaJson);
                
            
           
   

        }
    }
}
