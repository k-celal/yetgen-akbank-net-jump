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
                new BankAcc {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Hasan",LastName="Deniz",PhoneNumber="5558529637"},

                new BankAcc {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DB"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Mehmet",LastName="Öz",PhoneNumber="5417418529"},

                new BankAcc {Id=Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DC"), CreatedOn = DateTime.UtcNow,
                    CreatedByUserId="1", FirstName="Ahmet",LastName="Cad",PhoneNumber="5329637418"}
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
