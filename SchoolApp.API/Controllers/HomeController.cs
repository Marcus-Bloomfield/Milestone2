using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApp.API.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.API.Controllers
{
    /*Course: 		Web Programming 3
* Assessment: 	Milestone 2
* Created by: 	Marcus Bloomfield - 2264053
* Date: 		<10> <11> 2024
* Class Name:   HomeController.cs
* Description:  This class is the home controller that gets responses based on user roles. 
* Time Task B):	2 hrs
*/
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        [HttpGet("student")]
        [Authorize(Roles = UserRoles.Student)]
        public IActionResult GetStudent()
        {
            return Ok("Welcome to HomeController - Student");
        }
        [HttpGet("manager")]
        [Authorize(Roles = UserRoles.Manager)]
        public IActionResult GetManager()
        {
            return Ok("Welcome to HomeController - Manager");
        }
    }
}
