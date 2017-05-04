using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(skyerichelle.com.Startup))]
namespace skyerichelle.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
