using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webform2024.Startup))]
namespace Webform2024
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
