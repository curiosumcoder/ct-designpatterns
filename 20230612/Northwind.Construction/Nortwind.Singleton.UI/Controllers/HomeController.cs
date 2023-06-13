using Microsoft.AspNetCore.Mvc;
using Nortwind.Singleton.UI.Models;
using System.Diagnostics;

namespace Nortwind.Singleton.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Northwind.Singleton.MyCounter _counter;

        public HomeController(ILogger<HomeController> logger, Northwind.Singleton.MyCounter counter)
        {
            _logger = logger;
            _counter = counter;
        }

        public IActionResult Index()
        {
            _counter.Value++;

            ViewBag.visitors = _counter.Value.ToString();

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