using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDo_Calendar.Startup))]
namespace ToDo_Calendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
