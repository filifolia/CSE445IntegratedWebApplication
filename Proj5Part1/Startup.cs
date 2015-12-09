using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proj5Part1.Startup))]
namespace Proj5Part1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
