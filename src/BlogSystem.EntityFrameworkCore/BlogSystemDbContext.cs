using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Data;
using Youshow.Ace.EntityFrameworkCore;

namespace BlogSystem.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class BlogSystemDbContext : AceDbContext<BlogSystemDbContext>
    {
        public BlogSystemDbContext(DbContextOptions<BlogSystemDbContext> options) : base(options)
        {
        }
    }
}
