using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeshavPandey_Blog.Startup))]
namespace KeshavPandey_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
