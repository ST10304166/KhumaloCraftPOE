using KhumaloCraftPOE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KhumaloCraftPOE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int userID)
    {
        ViewData["userID"] = userID;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult MyWork()
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