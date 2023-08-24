using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSystem.Ability.Docking.Dto
{
    public class UserSignupDto
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public string? Gender { get; set; }

        public DateTime Birthday { get; set; }


        public string? Email { get; set; }





    }
}