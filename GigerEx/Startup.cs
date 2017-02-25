using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigerEx.Startup))]
namespace GigerEx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
