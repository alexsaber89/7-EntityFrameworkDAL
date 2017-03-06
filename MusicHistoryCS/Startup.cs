using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicHistoryCS.Startup))]
namespace MusicHistoryCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
