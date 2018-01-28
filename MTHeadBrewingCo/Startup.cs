using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MTHeadBrewingCo.Startup))]
namespace MTHeadBrewingCo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
