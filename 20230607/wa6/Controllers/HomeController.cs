using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using wa6.Models;

namespace wa6.Controllers;

// /Home/Index
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // https://localhost:7199/?filter=a
    public IActionResult Index(string filter="")
    {
        //ViewBag
        //ViewData
        //return View("");

        ViewBag.filter = filter;

        var pD = new wa6.Data.ProductD();
        var model = pD.List();

        // LINQ (Language Integrated Query, aka/C++: algorithms)
        //model = model.Where(p => p.Name.Contains(filter)).ToList();
        model = model.Where(p => p.Name.Contains(filter, 
        StringComparison.CurrentCultureIgnoreCase)).ToList();

        return View(model);
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
