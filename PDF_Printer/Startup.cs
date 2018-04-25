using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDF_Printer.Startup))]
namespace PDF_Printer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
