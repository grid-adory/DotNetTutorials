using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chap1.Startup))]
namespace Chap1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
