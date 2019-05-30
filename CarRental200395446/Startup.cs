using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarRental200395446.Startup))]
namespace CarRental200395446
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
