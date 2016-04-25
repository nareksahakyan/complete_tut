using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(complete_tut.Startup))]
namespace complete_tut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
