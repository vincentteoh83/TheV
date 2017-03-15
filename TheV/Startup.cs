using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheV.Startup))]
namespace TheV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
