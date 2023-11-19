using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using TaxiDriver.API.Models;
using Week_7_3.Domain.Entities;
using Week_7_3.Persistence.Contexts;

namespace TaxiDriver.API.Controllers
{
    public class TaxiDriversController : Controller
    {
        readonly Week_7_3DbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
