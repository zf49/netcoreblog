using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Ability.Docking.Dto
{
    public class LoginSuccessDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public string password { get; set; }

        public string Token { get; set; }
        


    }
}