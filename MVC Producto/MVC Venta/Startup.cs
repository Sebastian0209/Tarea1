using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Venta.Startup))]
namespace MVC_Venta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
