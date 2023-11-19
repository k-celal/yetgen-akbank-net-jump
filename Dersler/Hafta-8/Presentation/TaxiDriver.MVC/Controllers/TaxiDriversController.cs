using Microsoft.AspNetCore.Mvc;

namespace TaxiDriver.MVC.Controllers
{
    public class TaxiDriversController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
