using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_parcial1.Startup))]
namespace Mvc_parcial1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
