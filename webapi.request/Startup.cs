using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapi.request.Startup))]
namespace webapi.request
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
