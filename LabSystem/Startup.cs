using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LabSystem.Startup))]
namespace LabSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
