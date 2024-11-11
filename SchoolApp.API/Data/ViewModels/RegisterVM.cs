using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SchoolApp.API.Data.ViewModels
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	RegisterVM.cs
* Description:  This is a class that is used as a register view model for the api.
 */
    public class RegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
