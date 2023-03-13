using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2080600047.Startup))]
namespace _2080600047
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
