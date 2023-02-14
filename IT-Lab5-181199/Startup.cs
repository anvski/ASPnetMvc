using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Lab5_181199.Startup))]
namespace IT_Lab5_181199
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
