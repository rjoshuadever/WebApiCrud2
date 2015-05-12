using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApiCrud2.Startup))]
namespace WebApiCrud2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
