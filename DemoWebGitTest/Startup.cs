using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebGitTest.Startup))]
namespace DemoWebGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
