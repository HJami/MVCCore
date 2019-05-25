using Microsoft.Azure.WebJobs;

namespace WebJob1
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new JobHostConfiguration("DefaultEndpointsProtocol=https;AccountName=hjstorageacc;AccountKey=KxoXGHJTTvlGCEjVUsEfcC/iFE5CVLGqdHyjhvY5x5rLSbuh6UtrStk5x0QjVXF9cgg8CMDxIWWcLXXSMD/QmQ==;EndpointSuffix=core.windows.net");
            if (config.IsDevelopment)
            {
                config.UseDevelopmentSettings();
            }
            var host = new JobHost();
            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }
    }
}
