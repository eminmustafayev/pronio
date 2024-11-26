using Microsoft.AspNetCore.Mvc;

namespace PRONIO.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
