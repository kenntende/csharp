using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(movieproject.Startup))]
namespace movieproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
