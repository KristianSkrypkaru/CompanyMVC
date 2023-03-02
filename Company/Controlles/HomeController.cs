using Microsoft.AspNetCore.Mvc;

namespace Company.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
