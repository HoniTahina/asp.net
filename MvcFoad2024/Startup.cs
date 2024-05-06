using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcFoad2024.Startup))]
namespace MvcFoad2024
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
