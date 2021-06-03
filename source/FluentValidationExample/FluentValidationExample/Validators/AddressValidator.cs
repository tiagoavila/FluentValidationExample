using FluentValidation;
using FluentValidationExample.DTOs;

namespace FluentValidationExample.Validators
{
    public class AddressValidator : AbstractValidator<AddressDto>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Street).NotEmpty();
            RuleFor(x => x.Number).GreaterThan(0);
            RuleFor(x => x.City).NotEmpty();
            RuleFor(x => x.State).NotEmpty().Length(2);
            RuleFor(x => x.Country).NotEmpty();
            RuleFor(x => x.ZipCode).NotEmpty().Must(BeAValidZipCode).WithMessage("Please specify a valid zip code (it must have 5 characters)");
        }

        private bool BeAValidZipCode(string zipcode)
        {
            return zipcode.Length == 5;
        }
    }
}
