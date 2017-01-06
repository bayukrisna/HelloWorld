using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XIRPL1_08_BayuKrisna_HelloWord.Startup))]
namespace XIRPL1_08_BayuKrisna_HelloWord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
