using System;

namespace FluentValidationExample.DTOs
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public AddressDto Address { get; set; }
    }
}
