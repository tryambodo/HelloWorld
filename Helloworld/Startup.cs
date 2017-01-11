using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Helloworld.Startup))]
namespace Helloworld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
