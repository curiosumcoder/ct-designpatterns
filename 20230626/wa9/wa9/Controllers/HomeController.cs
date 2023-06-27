using Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wa9.Models;

namespace wa9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IGetList<int> _nums;

        public HomeController(ILogger<HomeController> logger, IGetList<int> nums)
        {
            _logger = logger;
            _nums = nums;
        }

        public IActionResult Index()
        {
            return View(_nums.GetList());
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