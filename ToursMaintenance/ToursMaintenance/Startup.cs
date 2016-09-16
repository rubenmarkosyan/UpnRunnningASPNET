using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToursMaintenance.Startup))]
namespace ToursMaintenance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
