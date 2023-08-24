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
                System.Console.WriteLine("11111111111111");

                System.Console.WriteLine(userSignupDto.Birthday);
                System.Console.WriteLine("11111111111111");


                var boo = await UserServicer.RegisterUser(userSignupDto);

                return boo;

        }



    }
}