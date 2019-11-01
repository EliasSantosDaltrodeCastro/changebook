using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChangeBook.Startup))]
namespace ChangeBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
