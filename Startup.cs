using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSVN.Startup))]
namespace WebSVN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
