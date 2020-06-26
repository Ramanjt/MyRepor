using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRepor.WebUI.Startup))]
namespace MyRepor.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
