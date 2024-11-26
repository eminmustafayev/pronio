using Microsoft.AspNetCore.Mvc;
using PRONIO.Models;
using System.Diagnostics;

namespace PRONIO.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home1()

        {
            return View();
        }

        public IActionResult About()

        {
            return View();
        }
        public IActionResult Blog()

        {
            return View();
        }
        public IActionResult BlogList()

        {
            return View();
        }
        public IActionResult BlogDetails()

        {
            return View();
        }
    }
}
