using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.ServiceBus.Messaging;

namespace WebJob2
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public void ProcessQueueMessage([ServiceBusTrigger("hjqueue")] string logMessage, TextWriter logger)
        {
            logger.WriteLine(logMessage);
        }
    }
}
