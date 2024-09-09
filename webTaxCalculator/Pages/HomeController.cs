using Microsoft.AspNetCore.Mvc;
using tinhthue_dll;

namespace webTaxCalculator.Pages
{
    public class HomeController : Controller
    {
        public class TaxController : Controller
        {
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Calculate(double income1, double income2)
            {
                // Sử dụng thư viện để tính toán thuế
                TaxCalculator calculator = new TaxCalculator

                {
                    tien1 = income1,
                    tien2 = income2
                };
                calculator.tinhtoathue();
                double result = calculator.sum;

                // Truyền kết quả sang View
                ViewBag.Result = result;
                return View("Index");
            }
        }
    }
}
