using BlogSystem.Ability.Docking;
using Microsoft.Extensions.DependencyInjection;
using Youshow.Ace.Http.Client;
using Youshow.Ace.Modularity;

namespace BlogSystem.Http.Client;
[RelyOn(
        typeof(AceHttpClientModule)
)]
public class BlogSystemHttpClientModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAceHttpClient(opt =>
        {
           opt.AddRemoteModule<BlogSystemAbilityDockingModule>("Default");
        });
    }

}
