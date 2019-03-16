using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Producto3Backend.Startup))]
namespace Producto3Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
