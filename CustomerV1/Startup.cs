using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerV1.Startup))]
namespace CustomerV1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
