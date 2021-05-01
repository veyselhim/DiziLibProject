using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class UserForRegisterDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }


    }
}
