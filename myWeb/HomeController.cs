using Microsoft.AspNetCore.Mvc;

namespace myWeb
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
