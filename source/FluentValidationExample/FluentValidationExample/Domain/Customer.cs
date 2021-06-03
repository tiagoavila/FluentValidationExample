using FluentValidationExample.Validators;
using System;

namespace FluentValidationExample.Domain
{
    public class Customer : ValidatedEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new CustomerValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
