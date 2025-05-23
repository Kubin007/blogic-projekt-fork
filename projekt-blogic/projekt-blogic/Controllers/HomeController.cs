using Microsoft.AspNetCore.Mvc;
using projekt_blogic.Models;
using System.Diagnostics;

namespace projekt_blogic.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Sprava()
        {
            return View();
        }

        public IActionResult Kosik()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registrace()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }
    }
}
