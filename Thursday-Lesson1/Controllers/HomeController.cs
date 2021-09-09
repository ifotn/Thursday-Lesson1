using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Thursday_Lesson1.Models;

namespace Thursday_Lesson1.Controllers
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

        // make a new method that will load at /Home/About
        public IActionResult About()
        {
            /* IActionResult usually returns a view (a web page) but could also return:
             * json object, HTTP Status Code (e.g. 404 / 401), file, redirect */

            // use the ViewBag container object to pass a simple message to be displayed in the view
            ViewBag.currentTime = DateTime.Now;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
