using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Task3.Startup))]
namespace Task3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
