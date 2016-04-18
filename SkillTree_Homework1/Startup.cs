using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkillTree_Homework1.Startup))]
namespace SkillTree_Homework1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
