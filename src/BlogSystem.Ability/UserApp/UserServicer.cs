using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.Dto;
using BlogSystem.Ability.Docking.UserApp;
using BlogSystem.Domain.AccountInfo;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Ability.UserApp
{
    public class UserServicer:AbilityServicer,IUserServicer
    {
       
        public IRepository<User> UserRepo { get; set; }

        public async Task<LoginSuccessDto> CheckLogin(string userName,string password){

            var user = await User.CheckLogin(userName, password,UserRepo);

            var res = ModelMapper.Map<User,LoginSuccessDto>(user);
            res.Token = Guid.NewGuid().ToString();
            return res;
        }




    }
}