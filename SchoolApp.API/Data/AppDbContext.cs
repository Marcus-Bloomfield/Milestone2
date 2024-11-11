using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolApp.API.Data.Models;

namespace SchoolApp.API.Data
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	AppDbContext.cs
* Description:  This is a class that is used as context to define the database tables, it also has information with the connection string and etc.
 */
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
