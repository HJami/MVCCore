using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace WebApplication1.Services
{
    public class StorageService: IStorageService
    {
        public CloudStorageAccount stAcc;
        public StorageService()
        {
            stAcc = new CloudStorageAccount(
            new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials
               ("myacc12", "xmIw+CvPb1H1nO0b3Ds+1njRPwwhkqGQlwqXDjNZpsRPb03Zve/I3wstJzqEjZhDWgKpgaPLqemB+39jUtnZkQ=="),
             true);

        }

        public CloudTableClient GetTableClient()
        {
            return stAcc.CreateCloudTableClient();
        }
    }
}
