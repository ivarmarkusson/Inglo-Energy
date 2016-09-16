using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inglo.Startup))]
namespace Inglo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
