using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;

namespace BlogSystem.Domain.AccountInfo
{
    public class User:BaseModel<int>
    {
        public string UserName { get; set;}
        public string Password { get; set;}
        
        

        
    }
}