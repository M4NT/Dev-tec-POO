using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_manha.Models;

namespace WebApp_manha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // action result devolve uma tela
        public IActionResult Index()
        {
            return View();
        }
        // mais uma tela no sistema
        public IActionResult BemVindo()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DropDow()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}