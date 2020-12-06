using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HouseHoldApplianceStore.Startup))]
namespace HouseHoldApplianceStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
