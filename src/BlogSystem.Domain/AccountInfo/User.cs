using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Domain.AccountInfo
{
    public class User : BaseModel<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }



        // Check user login 
        public static async Task<User> CheckLogin(string userName, string password,IRepository<User> userRepo)
        {

            var user = await userRepo.GetAsync(u => u.UserName == userName && u.Password==password);
            
            return user;
        }


    }

}
