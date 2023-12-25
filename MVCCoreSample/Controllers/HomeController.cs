using Microsoft.AspNetCore.Mvc;
using MVCCoreSample.Models;
using System.Diagnostics;

namespace MVCCoreSample.Controllers
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
        public IActionResult Ornek()
        {
            //object name = "John Doe";
            //string name = "John Doe";
            User _user = new User();
            _user.FirstName = "John";
            _user.LastName = "Doe";
            _user.BirthDate = DateTime.Now.AddYears(-40);
            return View(_user);
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