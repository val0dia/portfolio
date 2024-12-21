using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
