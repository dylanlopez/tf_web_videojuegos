using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoJuegosSite.Startup))]
namespace VideoJuegosSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
