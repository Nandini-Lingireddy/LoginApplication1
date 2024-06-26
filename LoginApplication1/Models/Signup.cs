﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LoginApplication1.Models
{
    public class Signup
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Key]
        public string Email { get; set; }

        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int Zipcode { get; set; }
    }
 
}
