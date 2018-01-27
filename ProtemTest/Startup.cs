using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProtemTest.Startup))]
namespace ProtemTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
