using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Cliente.Startup))]
namespace MVC_Cliente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
