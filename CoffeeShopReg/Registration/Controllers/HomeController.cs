using Microsoft.AspNetCore.Mvc;
using Registration.Models;
using System.Diagnostics;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(RegistrationForm model)
        {
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register(RegistrationForm model)
        {

            return View("RegisterUser", model);
        }

        [HttpPost]
        public IActionResult RegisterNewUser(RegistrationForm model)
        {
            
            return RedirectToAction("Index", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}