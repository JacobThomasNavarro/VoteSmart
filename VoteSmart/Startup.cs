using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoteSmart.Startup))]
namespace VoteSmart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
