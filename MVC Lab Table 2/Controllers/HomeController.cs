using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Lab_Table_2.Models;

namespace MVC_Lab_Table_2.Controllers
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

        public IActionResult MileageForm()
        {
            return View();
        }

        public IActionResult MileageResult(double mpg, double gallons, double trip)
        {

            double range = gallons * mpg;
            string result;

            if (range < trip)
            {
                result = "You need more gas";
            }
            else
            {
                result = "You have enough gas";
            }
            return View("Mileage", result);
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
