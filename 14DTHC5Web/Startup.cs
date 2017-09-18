using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_14DTHC5Web.Startup))]
namespace _14DTHC5Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
