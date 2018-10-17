using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConsultorioWeb.Startup))]
namespace ConsultorioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
