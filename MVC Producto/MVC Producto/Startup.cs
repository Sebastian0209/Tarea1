using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Producto.Startup))]
namespace MVC_Producto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
