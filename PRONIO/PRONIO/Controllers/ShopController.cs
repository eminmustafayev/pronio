using Microsoft.AspNetCore.Mvc;

namespace PRONIO.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
