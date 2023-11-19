using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxiDriver.API.Models;
using Week_7_3.Persistence.Contexts;

namespace TaxiDriver.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiDriversCont : ControllerBase
    {
        readonly Week_7_3DbContext _context;
        public TaxiDriversCont()
        {
            _context = new();
        }
        [HttpPost("[action]")]
        public IActionResult Create([FromBody] CreateTaxiDriver createTaxiDriver)
        {
            Week_7_3.Domain.Entities.TaxiDriver taxiDriver = new()
            {
                Name = createTaxiDriver.Name,
                Surname = createTaxiDriver.Surname,
                PhoneNumber = createTaxiDriver.PhoneNumber,
                LicencePlate = createTaxiDriver.LicencePlate

            };
            _context.TaxiDrivers.Add(taxiDriver);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("[action]")]
        public IActionResult Delete([FromBody] Guid id)
        {
            var taxiDriver = _context.TaxiDrivers.FirstOrDefault(t => t.Id == id);
           
            if (taxiDriver == null)
            {
                return NotFound();
            }
            _context.TaxiDrivers.Remove(taxiDriver);
            _context.SaveChanges();
            return Ok();


        }

    }
    
}
