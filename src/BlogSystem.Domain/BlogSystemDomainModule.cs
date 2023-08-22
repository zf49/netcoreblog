using Youshow.Ace.Domain;
using Youshow.Ace.Modularity;

namespace BlogSystem.Domain;
[RelyOn(
    typeof(AceDomainModule)
)]
public class BlogSystemDomainModule : AceModule
{

}
