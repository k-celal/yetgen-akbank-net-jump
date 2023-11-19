using Week_7_3.Domain.Entities;

namespace TaxiDriver.API.Models
{
    public class CreateTaxiDriver
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string LicencePlate { get; set; }
    }
}
