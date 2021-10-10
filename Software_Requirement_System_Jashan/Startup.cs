using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Software_Requirement_System_Jashan.Startup))]
namespace Software_Requirement_System_Jashan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
