using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SesinoksPompaProgrami.Startup))]
namespace SesinoksPompaProgrami
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
