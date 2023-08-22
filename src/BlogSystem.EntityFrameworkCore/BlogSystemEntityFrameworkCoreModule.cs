using Microsoft.Extensions.DependencyInjection;
using BlogSystem.Domain;
using Youshow.Ace.EntityFrameworkCore;
using Youshow.Ace.Modularity;

namespace BlogSystem.EntityFrameworkCore;
[RelyOn(
    typeof(AceEntityFrameworkCoreModule),
    typeof(BlogSystemDomainModule)
)]
public class BlogSystemEntityFrameworkCoreModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAceDbContext<BlogSystemDbContext>(opts=>
        {
            opts.AddDefaultRepositories(true);
        });
        Configure<AceDbContextOptions>(opts=>{
            opts.UseMySQL();
        });
    }
}
