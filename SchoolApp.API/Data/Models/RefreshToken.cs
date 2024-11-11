using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolApp.API.Data.Models
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	RefreshToken.cs
* Description:  This is a class that is used as a refresh token model for the table in the database.
   */
    public class RefreshToken
    {
        [Key]
        public int Id { get; set; }

        public string Token { get; set; }

        public string JwtId { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateExpire { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
