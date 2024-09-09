using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTax.Models;
using tinhthue_dll;

namespace WebTax.Controllers
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

        public IActionResult Tinhtoan(double tien1,double tien2, double ptthue)
        {
            TaxCalculator taxCalculator = new TaxCalculator();
            taxCalculator.thue = ptthue;
            taxCalculator.tien1 = tien1;
            taxCalculator.tien2 = tien2;
            taxCalculator.tinhtoathue();
            tien1 = taxCalculator.sum;
            return View("index",tien1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
