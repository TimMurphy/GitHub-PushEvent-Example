using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GitHub.PushEvent.Example.Startup))]

namespace GitHub.PushEvent.Example
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}