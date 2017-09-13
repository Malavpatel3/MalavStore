using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRental1.Startup))]
namespace MovieRental1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
