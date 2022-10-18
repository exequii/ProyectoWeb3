using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ProyectoWeb3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mundial()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult ChatBot()
        {
            return View();
        }

    }
}