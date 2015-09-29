using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_mvc_test.Startup))]
namespace asp_mvc_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
