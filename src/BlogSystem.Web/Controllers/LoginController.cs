using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking;
using BlogSystem.Ability.Docking.Dto;
using BlogSystem.Ability.Docking.UserApp;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        
        public IUserServicer UserServicer { get; set; }


        [HttpGet]
        public async Task<LoginSuccessDto> CheckLogin(string username, string password){
            System.Console.WriteLine(username);
            return await UserServicer.CheckLogin(username, password);

        }


    }
}