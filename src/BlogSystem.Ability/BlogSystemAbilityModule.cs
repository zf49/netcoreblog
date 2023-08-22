using BlogSystem.EntityFrameworkCore;
using BlogSystem.Ability.Docking;
using Youshow.Ace.Ability;
using Youshow.Ace.AutoMapper;
using Youshow.Ace.Modularity;
using Youshow.Ace.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace BlogSystem.Ability;
[RelyOn(
    typeof(AceAbilityModule),
    typeof(AceAutoMapperModule),
    typeof(AceLoggerModule),
    typeof(BlogSystemAbilityDockingModule),
    typeof(BlogSystemEntityFrameworkCoreModule)
)]
public class BlogSystemAbilityModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddAceLogger(
            opt=>opt.UseFile()
                    .UseElasticSearch(false)
        );
    }
}
