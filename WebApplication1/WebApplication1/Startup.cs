using Microsoft.Owin;
using Owin;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

[assembly: OwinStartup(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }

    }
}