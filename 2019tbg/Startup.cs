using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2019tbg.Startup))]
namespace _2019tbg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
