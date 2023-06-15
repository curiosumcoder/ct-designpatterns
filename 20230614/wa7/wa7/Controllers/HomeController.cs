using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Northwind.Model;
using Nothwind.Data;
using System.Diagnostics;
using wa7.Models;

namespace wa7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IMaintenance<Product> pD;

        public HomeController(ILogger<HomeController> logger, IMaintenance<Product> pD)
        {
            _logger = logger;
            this.pD = pD;
        }

        public IActionResult Index()
        {
            var model = this.pD.List();

            return View(model);
        }

        public IActionResult Create(Product? p)
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