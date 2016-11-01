using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ariwebapp.Startup))]
namespace ariwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
