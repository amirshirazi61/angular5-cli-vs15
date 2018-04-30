using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angularQuickstart.Startup))]
namespace angularQuickstart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
