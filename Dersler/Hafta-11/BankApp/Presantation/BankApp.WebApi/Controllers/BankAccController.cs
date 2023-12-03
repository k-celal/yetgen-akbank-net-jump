using BankApp.Domain.Entities;
using BankApp.Persistence.Context;
using BankApp.WebApi.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.WebApi.Controllers
{
    public class BankAccController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class BankAccountsController : Controller
        {
            public BankAppDbContext _bankAppDbContext;

            public BankAccountsController(BankAppDbContext bankAppDbContext)
            {
                _bankAppDbContext = bankAppDbContext;
            }

            [HttpPost("[action]")]
            public void SetDefaultUsersData()
            {
                List<BankAcc> people = new()
            {
                new BankAcc {Id=Guid.Parse("A1E90212-8CC6-4D0E-9A77-25D3D5F5A9C1"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Berkin",LastName="Dundar",PhoneNumber="5558529637"},

                new BankAcc {Id=Guid.Parse("B2F8C478-A889-4BC0-8B1D-765FC21946D7"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Umut",LastName="Mercan",PhoneNumber="5417418529"},

                new BankAcc {Id=Guid.Parse("C3D71A6F-4E16-48A2-B7F7-7B634D88E3BD"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Celal",LastName="Karahan",PhoneNumber="5329637418"}
            };

                _bankAppDbContext.People.AddRange(people);

                _bankAppDbContext.SaveChanges();
            }


            [HttpGet("[action]/{bankAccountId:guid}")]
            public BankAccDataResponseModel GetBankAccountData(Guid bankAccountId)
            {
                var bankAccount = _bankAppDbContext.People.FirstOrDefault(x => x.Id == bankAccountId);

                var response = new BankAccDataResponseModel()
                {
                    Balance = bankAccount.Balance,
                    LastName = bankAccount.LastName,
                    FirstName = bankAccount.FirstName
                };
                return response;
            }
        }
    }
}
