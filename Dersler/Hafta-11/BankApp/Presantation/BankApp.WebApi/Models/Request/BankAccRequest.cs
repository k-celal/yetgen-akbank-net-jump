using BankApp.WebApi.Models.ModelMetadataTypes;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.WebApi.Models.Request
{
    [ModelMetadataType(typeof(BankAccMetadata))]
    public class BankAccontRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
    }
}
