using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.Dto;
using BlogSystem.Ability.Docking.UserApp;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignUpController : ControllerBase
    {
        
            public IUserServicer UserServicer { get; set; }


            [HttpPost]
            public async Task<bool> SignUp(UserSignupDto userSignupDto){

                var boo = await UserServicer.RegisterUser(userSignupDto);

                return boo;



        }



    }
}