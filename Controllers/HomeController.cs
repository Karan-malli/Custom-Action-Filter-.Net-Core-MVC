using CustomActionFilter.Filters;
using CustomActionFilter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomActionFilter.Controllers
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

        public IActionResult SaveUserInfo()
        {
            return View();
        }

        [DateTimeConvertor]
        [HttpPost]
        public IActionResult SaveUserInfo(CheckInModel model)
        {
            //InTime will have Universal Time
            var inTime = model.InTime;

            return View("Index");
        }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}