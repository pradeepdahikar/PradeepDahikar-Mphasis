using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mphasis.MVC.AddTwoNumbers.Startup))]
namespace Mphasis.MVC.AddTwoNumbers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
