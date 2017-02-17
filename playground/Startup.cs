using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(playground.Startup))]
namespace playground
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
