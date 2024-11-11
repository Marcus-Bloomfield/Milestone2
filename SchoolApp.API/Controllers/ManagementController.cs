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
* Class Name:   ManagementController.cs
* Description: 	This class is a controller dedicated to managers which restricts reponses for students and other potential roles.
* Time Task B):	2 hrs
*/
    [Authorize(Roles = UserRoles.Manager)]
    [ApiController]
    [Route("[controller]")]
    public class ManagementController : ControllerBase
    {
        public ManagementController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to ManagementController");
        }
    }
}
