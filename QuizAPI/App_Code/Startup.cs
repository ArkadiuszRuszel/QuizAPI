using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuizAPI.Startup))]
namespace QuizAPI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
