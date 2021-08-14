using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maintainance.Startup))]
namespace Maintainance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        
        }
    }
}
