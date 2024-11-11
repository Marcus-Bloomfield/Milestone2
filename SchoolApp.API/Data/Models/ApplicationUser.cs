using Microsoft.AspNetCore.Identity;

namespace SchoolApp.API.Data.Models
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	ApplicationUser.cs
* Description:  This is a class that is used as a user model for the table in the database. It has a parent class of identity user which has many more fields.
   */
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Custom { get; set; }
    }
}
