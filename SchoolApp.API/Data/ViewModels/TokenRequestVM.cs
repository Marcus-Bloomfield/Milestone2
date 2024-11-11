using System.ComponentModel.DataAnnotations;

namespace SchoolApp.API.Data.ViewModels
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	TokenRequestVM.cs
* Description:  This is a class that is used as a token request view model for the api.
 */
    public class TokenRequestVM
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}
