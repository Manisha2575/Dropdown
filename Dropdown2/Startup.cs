using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dropdown2.Startup))]
namespace Dropdown2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
