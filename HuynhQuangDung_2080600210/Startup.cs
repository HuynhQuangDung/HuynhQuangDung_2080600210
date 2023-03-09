using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhQuangDung_2080600210.Startup))]
namespace HuynhQuangDung_2080600210
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
