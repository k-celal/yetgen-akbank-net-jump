using Microsoft.AspNetCore.Mvc;
using Hafta10Odev_2.Infrastructure.Services;
namespace Hafta10Odev_2.API.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {

        }
        [HttpGet]
        public void Get(string name)
        {
            ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
