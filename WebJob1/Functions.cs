using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.IO;

namespace WebJob1
{
    public class Functions
    {
        private readonly ILogger<Functions> logger;

        public Functions(ILogger<Functions> logger)
        {
            this.logger = logger;
        }

        public void ProcessQueueMessage([ServiceBusTrigger("hjqueue")] string logMessage, TextWriter logger)
        {
            logger.WriteLine(logMessage);
            var stAcc = new CloudStorageAccount(
                             new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials
                                ("hjstorageacc", "KxoXGHJTTvlGCEjVUsEfcC/iFE5CVLGqdHyjhvY5x5rLSbuh6UtrStk5x0QjVXF9cgg8CMDxIWWcLXXSMD/QmQ=="),
                        true);
            /*var blbClient = stAcc.CreateCloudBlobClient();
            var container = blbClient.GetContainerReference("azure-webjobs-hosts");
            var blb = container.GetBlockBlobReference("output-logs/blb");
            blb.UploadTextAsync(logMessage);*/
            var qc = stAcc.CreateCloudQueueClient();
            var q = qc.GetQueueReference("myqueue");
            q.AddMessageAsync(new Microsoft.WindowsAzure.Storage.Queue.CloudQueueMessage(logger.ToString()));

        }

    }
}
