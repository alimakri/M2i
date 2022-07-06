using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoSecure1.Startup))]
namespace DemoSecure1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
