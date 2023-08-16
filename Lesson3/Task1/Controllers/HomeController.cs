using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task1.Database;
using Task1.Models;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDatabaseService _db;

        public HomeController(
            ILogger<HomeController> logger,
            IDatabaseService db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Login");
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