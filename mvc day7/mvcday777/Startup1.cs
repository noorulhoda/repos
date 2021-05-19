using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(mvcday777.Startup1))]

namespace mvcday777
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                //NAme
                ExpireTimeSpan = TimeSpan.FromSeconds(60),
                //Life Tim
                LoginPath = new PathString(@"/Account/Login"),
                //REdirect Login
            });
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
