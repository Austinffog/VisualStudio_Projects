using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoePersonalBudget.Startup))]
namespace PoePersonalBudget
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
