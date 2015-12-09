using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proj5Part2.Startup))]
namespace Proj5Part2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
