using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FluentValidationExample.Controllers
{
    public class ValidatedEntityController : ControllerBase
    {
        public ValidationResult ValidationResult;

        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResponseBasedOnValidation()
        {
            if (ValidationResult?.IsValid == true)
            {
                return Ok();
            }

            return BadRequest(ValidationResult.Errors.Select(x => x.ErrorMessage));
        }
    }
}
