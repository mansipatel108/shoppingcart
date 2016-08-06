using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingcart_lab.Startup))]
namespace shoppingcart_lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
