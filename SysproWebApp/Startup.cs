using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SysproWebApp.Startup))]
namespace SysproWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
