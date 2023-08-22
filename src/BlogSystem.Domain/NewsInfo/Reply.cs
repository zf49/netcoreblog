using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;

namespace BlogSystem.Domain.NewsInfo
{
    public class Reply : BaseModel<int>
    {

        public int UserId { get; set; }

        public string NickName { get; set; }

        public int ReplyTitle { get; set; }

        public int NewsId { get; set; }

        public int ReplyDate { get; set; }

        public string ReplyContent { get; set; }

    }
}