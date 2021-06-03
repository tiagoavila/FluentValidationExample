using FluentValidationExample.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FluentValidationExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { ListOfErrors = ModelState.Values.SelectMany(t => t.Errors).Select(t => t.ErrorMessage).ToList() });
            }

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Test = "Hi" });
        }

    }
}
