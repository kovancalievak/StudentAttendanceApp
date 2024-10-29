using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentAttendanceWebApp.Startup))]
namespace StudentAttendanceWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
