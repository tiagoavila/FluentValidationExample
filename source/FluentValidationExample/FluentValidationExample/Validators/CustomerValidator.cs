using FluentValidation;
using FluentValidationExample.DTOs;
using System;

namespace FluentValidationExample.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a last name");
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Address).NotNull().SetValidator(new AddressValidator());
            RuleFor(x => x.BirthDay).Must(HaveAtLeastEighteenYearsOld).When(x => x.Address.Country.Equals("brazil", StringComparison.OrdinalIgnoreCase)).WithMessage("Brazilian customers must have at least 18 years old");
        }

        private bool HaveAtLeastEighteenYearsOld(DateTime birthday)
        {
            return DateTime.Now.Year - birthday.Year >= 18;
        }
    }
}
