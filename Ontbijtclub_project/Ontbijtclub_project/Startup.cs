using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ontbijtclub_project.Startup))]
namespace Ontbijtclub_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
