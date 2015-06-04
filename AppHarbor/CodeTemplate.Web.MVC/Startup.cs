using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeTemplate.Web.MVC.Startup))]
namespace CodeTemplate.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
