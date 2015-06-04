using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CodeTemplates.WebMVCWebApi.Startup))]

namespace CodeTemplates.WebMVCWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
