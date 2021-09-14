using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Summative_7103.Startup))]
namespace Summative_7103
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
