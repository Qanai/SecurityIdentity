using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityIdentity.Web.Startup))]
namespace SecurityIdentity.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
