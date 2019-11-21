using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TextBased.Web.Startup))]
namespace TextBased.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
