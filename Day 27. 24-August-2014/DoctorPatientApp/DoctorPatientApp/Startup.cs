using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoctorPatientApp.Startup))]
namespace DoctorPatientApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
