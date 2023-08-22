using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.EntityFrameworkCore;
using Youshow.Ace.EntityFrameworkCore.MySql;

namespace BlogSystem.EntityFrameworkCore
{
    public class BlogSystemDesignTimeFactory : AceMySqlDesignTimeDbContextFactory<BlogSystemDbContext>
{
    public override AceDesignTimeDbContextOptions Options => new()
    {
        StartupProjectPath = @"../BlogSystem.Web" //appsetting.json所在目录
    };
}
}
