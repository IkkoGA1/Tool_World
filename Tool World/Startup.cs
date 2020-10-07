using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tool_World.Startup))]
namespace Tool_World
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
