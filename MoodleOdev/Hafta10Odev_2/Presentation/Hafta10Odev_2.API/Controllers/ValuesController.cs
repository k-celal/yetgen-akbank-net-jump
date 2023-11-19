using Hafta10Odev_2.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hafta10Odev_2.API.Controllers
{
    public class ValuesController : Controller
    {
        public ValuesController()
        {

        }
        [HttpGet]
        public void Get(string name)
        {
            ConfigurationService.GetInstance().GetValue(name);
        }
    }
}
