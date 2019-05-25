using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
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

        public void ProcessQueueMessage([ServiceBusTrigger("hjqueue", Connection = "Endpoint=sb://hjnamespace.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=QlVpxHO+t8ICpzjpW0qZ8eDU0fKW7zbDEvO2ROxClRs=")] string logMessage, TextWriter logger)
        {
            logger.WriteLine(logMessage);
        }
    }
}
