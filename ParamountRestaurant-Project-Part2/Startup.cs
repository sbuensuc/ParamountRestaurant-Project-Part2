using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParamountRestaurant_Project_Part2.Startup))]
namespace ParamountRestaurant_Project_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
