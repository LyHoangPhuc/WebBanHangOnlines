using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanHangOnlines.Startup))]
namespace WebBanHangOnlines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
