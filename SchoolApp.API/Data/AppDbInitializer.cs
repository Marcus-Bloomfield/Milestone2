using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SchoolApp.API.Data.Helpers;
using System.Threading.Tasks;

namespace SchoolApp.API.Data
{
    /*
* Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		10 11 2024
* Class Name: 	LoginVM.cs
* Description:  This is a class that is used too seed roles that a meant to exist by default in a database.
*               When the api is opened and the database has no roles, its made by default.
 */
    public class AppDbInitializer
    {
        public static async Task SeedRolesToDb(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Manager))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Manager));

                if (!await roleManager.RoleExistsAsync(UserRoles.Student))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Student));

            }
        }
    }
}
