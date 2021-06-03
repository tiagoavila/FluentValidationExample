using FluentValidation.Results;

namespace FluentValidationExample.Services
{
    public class GenericService<TEntity> where TEntity : ValidatedEntity
    {
        public ValidationResult _validationResult;
        public GenericService(ref ValidationResult validationResult)
        {
            _validationResult = validationResult;
        }

        public void AddEntity(TEntity entity)
        {
            if (entity.IsValid())
            {
                //create entity
            }
            else
            {
                _validationResult = entity.ValidationResult;
            }
        }
    }
}
