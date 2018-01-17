using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigProject.Startup))]
namespace GigProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
