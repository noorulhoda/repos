using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ConsoleAppSERVER.Startup1))]

namespace ConsoleAppSERVER
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
                app.UseCors(CorsOptions.AllowAll);//remote client web site allow
                app.MapSignalR();
        }
    }
}
