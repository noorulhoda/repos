using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(Day1.Startup1))]

namespace Day1
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();//Maping /signalr
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
