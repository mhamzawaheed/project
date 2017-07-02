using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectsWeb.Startup))]
namespace ProjectsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
