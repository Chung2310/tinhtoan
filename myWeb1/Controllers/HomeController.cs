using Microsoft.AspNetCore.Mvc;
using tinhthue_dll;

namespace YourNamespace.Controllers
{
    public class TaxController : Controller
    {
        // Hiển thị form nhập liệu
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Nhận dữ liệu từ form và tính thuế
        [HttpPost]
        public IActionResult Index(double income, double taxRate)
        {
            TaxCalculator calculator = new TaxCalculator();
            calculator.tien1 = income;
            calculator.tien2 = taxRate;
            calculator.tinhtoathue();
            ViewBag.TaxAmount = calculator.sum;
            return View();
        }
    }
}
