using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Hosting;

namespace WebJob1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorage();
                b.AddServiceBus((options) => options.ConnectionString = "Endpoint=sb://hjnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=QlVpxHO+t8ICpzjpW0qZ8eDU0fKW7zbDEvO2ROxClRs=");
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
