using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountPractice.Startup))]
namespace AccountPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
