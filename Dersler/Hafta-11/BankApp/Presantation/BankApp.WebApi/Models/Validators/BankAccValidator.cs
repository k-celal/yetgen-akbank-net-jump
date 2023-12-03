using BankApp.Domain.Entities;
using FluentValidation;

namespace BankApp.WebApi.Models.Validators
{
    public class BankAccValidator : AbstractValidator<BankAcc>
    {
        public BankAccValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithErrorCode("Ad boş olamaz!")
                .NotNull()
                .WithErrorCode("Ad null olamaz!")
                .MinimumLength(3)
                .MaximumLength(20)
                .WithErrorCode("Ad 3 ile 20 karakter arasında olmalıdır!");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithErrorCode("Soyad boş olamaz!")
                .NotNull()
                .WithErrorCode("Soyad null olamaz!")
                .MinimumLength(3)
                .MaximumLength(20)
                .WithErrorCode("Soyad 3 ile 20 karakter arasında olmalıdır!");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .WithErrorCode("Telefon numarası boş veya null olamaz!")
                .Matches(@"^(\d{11})$").WithErrorCode("Telefon numarası 11 basamaklı olmalıdır!");
        }

    }
}
