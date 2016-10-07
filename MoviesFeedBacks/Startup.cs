using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesFeedBacks.Startup))]
namespace MoviesFeedBacks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
