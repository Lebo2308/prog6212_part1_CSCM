using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prog6212_part1_CSCM.Models;

namespace prog6212_part1_CSCM.Controllers
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

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ApproveClaim()
        {
            return View();
        }

        public IActionResult PreapproveClaim()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult SubmitAClaim()
        {
            return View();
        }

        public IActionResult TrackClaim()
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
