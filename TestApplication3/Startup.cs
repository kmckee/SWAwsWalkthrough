using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestApplication3.Startup))]
namespace TestApplication3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
