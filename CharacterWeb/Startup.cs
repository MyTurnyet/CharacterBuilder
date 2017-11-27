using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CharacterWeb.Startup))]

namespace CharacterWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
