﻿using Microsoft.AspNetCore.Identity;

namespace SchoolApp.API.Data.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Custom { get; set; }
    }
}
