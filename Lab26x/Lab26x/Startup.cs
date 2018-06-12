using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab26x.Startup))]
namespace Lab26x
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
