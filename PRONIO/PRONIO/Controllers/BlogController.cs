using Microsoft.AspNetCore.Mvc;

namespace PRONIO.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
