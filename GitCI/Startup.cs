using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitCI.Startup))]
namespace GitCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
