using GitHub.PushEvent.Example;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace GitHub.PushEvent.Example
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}