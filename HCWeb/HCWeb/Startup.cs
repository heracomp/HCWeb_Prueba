using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HCWeb.Startup))]
namespace HCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
