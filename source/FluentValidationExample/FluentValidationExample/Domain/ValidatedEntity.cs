using FluentValidation.Results;

namespace FluentValidationExample.Domain
{
    public abstract class ValidatedEntity
    {
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
}
