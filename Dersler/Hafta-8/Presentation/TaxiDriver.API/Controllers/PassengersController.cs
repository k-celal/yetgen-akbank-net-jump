using Microsoft.AspNetCore.Mvc;

namespace TaxiDriver.API.Controllers
{
    public class PassengersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
