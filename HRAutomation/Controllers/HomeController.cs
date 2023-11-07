using HRAutomation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRAutomation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()// Action methods-respond enduser request from cshtml
        {
            return View();// return index.cshtml
        }

        public IActionResult Privacy() // 
        {
            return View();// return privacy.cshtml
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}