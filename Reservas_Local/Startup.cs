using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reservas_Local.Startup))]
namespace Reservas_Local
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
