using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(window.Startup))]
namespace window
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
