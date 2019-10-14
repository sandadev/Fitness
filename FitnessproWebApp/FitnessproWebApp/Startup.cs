using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessproWebApp.Startup))]
namespace FitnessproWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
