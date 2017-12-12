using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP229_Assign04.Startup))]
namespace COMP229_Assign04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
