using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JaywingGitDemo.Startup))]
namespace JaywingGitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
