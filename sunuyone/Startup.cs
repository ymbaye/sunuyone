using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sunuyone.Startup))]
namespace sunuyone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
