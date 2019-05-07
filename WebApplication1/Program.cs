using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.HttpSys;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                /*.UseHttpSys(options =>
                   {
                       options.Authentication.Schemes = AuthenticationSchemes.None;
                       options.Authentication.AllowAnonymous = true;
                       options.MaxConnections = null;
                       options.MaxRequestBodySize = 30000000;
                       //options.UrlPrefixes.Add("http://localhost:5000");
                   }
                )*/;

    }
}
