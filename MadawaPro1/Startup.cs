using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadawaPro1.Startup))]
namespace MadawaPro1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
