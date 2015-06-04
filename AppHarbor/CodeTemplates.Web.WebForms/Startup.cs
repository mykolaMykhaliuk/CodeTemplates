using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeTemplates.Web.WebForms.Startup))]
namespace CodeTemplates.Web.WebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
