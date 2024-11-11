using System.ComponentModel.DataAnnotations;

namespace SchoolApp.API.Data.ViewModels
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	LoginVM.cs
* Description:  This is a class that is used as a login view model for the api.
 */
    public class LoginVM
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
